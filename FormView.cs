using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ПлавающиеФигуры.Engine;


// Simple change
// Changed again!
//Oh my God, AGAIN!

namespace Плавающие_фигуры
{
    public partial class FormView : Form, IView, INumberOfShapesObserver
    {
        // Перечисляемая константа количества предыдущих кликов на кнопку
        enum ButtonClicks { None, One };
        ButtonClicks AddShapeButtonClicks;


        const int MAX_SHAPE_SIZE_VARIABLE = 50;
        const int MIN_SHAPE_SIZE_VARIABLE = 15;

        /// <summary>
        /// Модель, количество фигур в которой обозревает вид
        /// </summary>
        private IShapesModel observableModel;

        public FormView(IShapesModel model, int area_width,int area_height,int area_offset)
        {
            
            InitializeComponent();

            // Создаем интерфейс к модели и регистрируемся в ней
            observableModel = model;
            observableModel.registerNumberOfShapesObserver(this);

            // Блокируем изменение размеров модели
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.MaximizeBox = false;

            // Задаем ограничения на габариты добавляемых фигур
            sizeVariable1Numeric.Minimum = MIN_SHAPE_SIZE_VARIABLE;
            sizeVariable1Numeric.Maximum = MAX_SHAPE_SIZE_VARIABLE;

            sizeVariable2Numeric.Minimum = MIN_SHAPE_SIZE_VARIABLE;
            sizeVariable2Numeric.Maximum = MAX_SHAPE_SIZE_VARIABLE;

            // Нижняя граница номера удаляемой фигуры, естественно, 1 =)
            // Верхняя граница задается динамически, но для начала тоже 1
            numberOfShapeToRemoveNumeric.Minimum = 1;
            numberOfShapeToRemoveNumeric.Maximum = 1;

            // Раз сначала фигур нет, нельзя ничего и удалить
            // В дальнейшем доступность этих виджетов будет контролироваться наблюдением за моделью
            numberOfShapeToRemoveNumeric.Enabled = false;
            removeShapeButton.Enabled = false;

            // Пока фигур нет, не стоит и отображать их количество
            numberOfShapesGroupBox.Visible = false;

            // Приводим элементы добавления фигур в "боевое" состояние
            ResetAddControls();
            
        }

        #region IView Members

        public event EventHandler<EventArgs> StartMoving;

        public event EventHandler<EventArgs> Pause;

        public event EventHandler<EventArgs> StopMoving;

        public event EventHandler<EventArgs> AddCircle;

        public event EventHandler<EventArgs> AddTriangle;

        public event EventHandler<EventArgs> AddRectangle;

        public event EventHandler<EventArgs> AddSquare;

        public event EventHandler<EventArgs> RemoveShape;

        public int RectangleWidth
        {
            get { return (int)sizeVariable1Numeric.Value; }
        }

        public int RectangleLength
        {
            get { return (int)sizeVariable2Numeric.Value; }
        }

        public int CircleRadius
        {
            get { return (int)sizeVariable1Numeric.Value; }
        }

        public int TriangleSide
        {
            get { return (int)sizeVariable1Numeric.Value; }
        }

        public int SquareSide
        {
            get { return (int)sizeVariable1Numeric.Value; }
        }

        public int NumberOfShapeToDelete
        {
            get { return (int)numberOfShapeToRemoveNumeric.Value; }
        }

        public void DrawArea(Bitmap area)
        {
            pictureBox1.Image = area;
            pictureBox1.Refresh();
        }
        public int MotionQ
        {
            get { return MQTrackBar.Value; }
        }

        public event EventHandler RefreshFrequencyChanged;

        public int RefreshFrequency
        {
            get { return RFTrackbar.Value; }
        }

        public bool DrawTails
        {
            get { return drawTailsCheckBox.Checked; }
        }

        #endregion
        #region INumberOfShapesObserver Members

        public void UpdateNumberOfShapes()
        {
            int TOTAL_NUMBER = observableModel.HowMuch.Rectangles +
                               observableModel.HowMuch.Circles +
                               observableModel.HowMuch.Triangles;
            // Если из модели удалены все фигуры, надо запретить
            // удаление фигур. Если же фигуры есть или появились,
            // такую возможность надо дать (с учетом ограничений!).
            if (TOTAL_NUMBER == 0)
            {
                numberOfShapeToRemoveNumeric.Enabled = false;
                removeShapeButton.Enabled = false;
            }
            else
            {
                numberOfShapeToRemoveNumeric.Enabled = true;
                removeShapeButton.Enabled = true;

                numberOfShapeToRemoveNumeric.Maximum = TOTAL_NUMBER;

                // Ах да, если фигура одна, то она скорее всего первая.
                // На всякий случай явно начинаем отображать значения количества фигур
                numberOfShapesGroupBox.Visible = true;
            }

            numberOfCirclesLabel.Text = observableModel.HowMuch.Circles.ToString();
            numberOfTrianglesLabel.Text = observableModel.HowMuch.Triangles.ToString();
            numberOfRectanglesLabel.Text = observableModel.HowMuch.Rectangles.ToString();
            numbeerOfSquaresLabel.Text = observableModel.HowMuch.Squares.ToString();

            numberOfShapesLabel.Text = TOTAL_NUMBER.ToString();
        }

        #endregion

        /// <summary>
        /// Приводит элементы добавления фигур в исходное состояние
        /// </summary>
        private void ResetAddControls()
        {
            newShapeSizePanel.Visible = false;


            sizeVariable1Numeric.Value = MIN_SHAPE_SIZE_VARIABLE;
            sizeVariable2Numeric.Value = MIN_SHAPE_SIZE_VARIABLE;

            addCircleButton.Enabled = true;
            addTriangleButton.Enabled = true;
            addRectangleButton.Enabled = true;
            addSquareButton.Enabled = true;

            AddShapeButtonClicks = ButtonClicks.None;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartMoving(sender,e);
            // Делаем доступным только то, что нужно
            startButton.Enabled = false;
            pauseButton.Enabled = true;
            stopButton.Enabled = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            Pause(sender, e);
            // Делаем доступным только то, что нужно
            pauseButton.Enabled = false;
            startButton.Enabled = true;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopMoving(sender, e);
            // Делаем доступным только то, что нужно
            pauseButton.Enabled = false;
            stopButton.Enabled = false;
            startButton.Enabled = true;
        }

        private void removeShapeButton_Click(object sender, EventArgs e)
        {
            RemoveShape(sender, e);
        }

        private void addCircleButton_Click(object sender, EventArgs e)
        {
            // Если кнопка нажата первый раз, начинаем ввод
            if (AddShapeButtonClicks == ButtonClicks.None)
            {
                // Активируем нужные элементы ввода данных
                newShapeSizePanel.Visible = true;
                sizeVariable1DescriptionLabel.Text = "Радиус:";

                sizeVariable2DescriptionLabel.Visible = false;
                sizeVariable2Numeric.Visible = false;

                // Делаем недоступными все остальные клавиши добавления фигур
                addTriangleButton.Enabled = false;
                addRectangleButton.Enabled = false;
                addSquareButton.Enabled = false;

                // И заодно удаления
                removeShapeButton.Enabled = false;
                numberOfShapeToRemoveNumeric.Enabled = false;

                // И ждем второго нажатия на клавишу после ввода данных
                AddShapeButtonClicks = ButtonClicks.One;
            }
            // Если кнопка нажата во второй раз, надо добавлять фигуру и возвращать 
            // элементы управления в исходное состояние
            else if (AddShapeButtonClicks == ButtonClicks.One)
            {
                AddCircle(sender, e);
                ResetAddControls();
            }

        }

        private void addTriangleButton_Click(object sender, EventArgs e)
        {
            // Если кнопка нажата первый раз, начинаем ввод
            if (AddShapeButtonClicks == ButtonClicks.None)
            {
                // Активируем НУЖНЫЕ элементы ввода данных
                newShapeSizePanel.Visible = true;
                sizeVariable1DescriptionLabel.Text = "Длина стороны:";

                sizeVariable2DescriptionLabel.Visible = false;
                sizeVariable2Numeric.Visible = false;

                // Делаем недоступными все остальные клавиши добавления фигур
                addCircleButton.Enabled = false;
                addRectangleButton.Enabled = false;
                addSquareButton.Enabled = false;

                // И заодно удаления
                removeShapeButton.Enabled = false;
                numberOfShapeToRemoveNumeric.Enabled = false;

                // И ждем второго нажатия на клавишу после ввода данных
                AddShapeButtonClicks = ButtonClicks.One;
            }
            // Если кнопка нажата во второй раз, надо добавлять фигуру и возвращать 
            // элементы управления в исходное состояние
            else if (AddShapeButtonClicks == ButtonClicks.One)
            {
                AddTriangle(sender, e);
                ResetAddControls();
            }
        }

        private void addSquareButton_Click(object sender, EventArgs e)
        {

            // Если кнопка нажата первый раз, начинаем ввод
            if (AddShapeButtonClicks == ButtonClicks.None)
            {
                // Активируем нужные элементы ввода данных
                newShapeSizePanel.Visible = true;
                sizeVariable1DescriptionLabel.Text = "Длина стороны:";

                sizeVariable2DescriptionLabel.Visible = false;
                sizeVariable2Numeric.Visible = false;

                // Делаем недоступными все остальные клавиши добавления фигур
                addTriangleButton.Enabled = false;
                addRectangleButton.Enabled = false;
                addCircleButton.Enabled = false;

                // И заодно удаления
                removeShapeButton.Enabled = false;
                numberOfShapeToRemoveNumeric.Enabled = false;

                // И ждем второго нажатия на клавишу после ввода данных
                AddShapeButtonClicks = ButtonClicks.One;
            }
            // Если кнопка нажата во второй раз, надо добавлять фигуру и возвращать 
            // элементы управления в исходное состояние
            else if (AddShapeButtonClicks == ButtonClicks.One)
            {
                AddSquare(sender, e);
                ResetAddControls();
            }
        }

        private void addRectangleButton_Click(object sender, EventArgs e)
        {

            // Если кнопка нажата первый раз, начинаем ввод
            if (AddShapeButtonClicks == ButtonClicks.None)
            {
                // Активируем нужные элементы ввода данных
                newShapeSizePanel.Visible = true;
                sizeVariable1DescriptionLabel.Text = "Ширина:";

                sizeVariable2DescriptionLabel.Visible = true;
                sizeVariable2DescriptionLabel.Text = "Длина:";

                sizeVariable2Numeric.Visible = true;

                // Делаем недоступными все остальные клавиши добавления фигур
                addTriangleButton.Enabled = false;
                addSquareButton.Enabled = false;
                addCircleButton.Enabled = false;

                // И заодно удаления
                removeShapeButton.Enabled = false;
                numberOfShapeToRemoveNumeric.Enabled = false;

                // И ждем второго нажатия на клавишу после ввода данных
                AddShapeButtonClicks = ButtonClicks.One;
            }
            // Если кнопка нажата во второй раз, надо добавлять фигуру и возвращать 
            // элементы управления в исходное состояние
            else if (AddShapeButtonClicks == ButtonClicks.One)
            {
                // Если умный пользователь добавляет прямоугольник с равными сторонами,
                // умный код добавляет квадрат =)
                if (sizeVariable1Numeric.Value == sizeVariable2Numeric.Value)
                {
                    MessageBox.Show("Вообще-то для добавления квадратов есть отдельная кнопка. Но если вам хочется так, то пожалуйста =)");
                    AddSquare(sender, e);
                }
                else
                {
                    AddRectangle(sender, e);
                }

                ResetAddControls();
            }
        }

        private void RFTrackbar_ValueChanged(object sender, EventArgs e)
        {
            RefreshFrequencyChanged(sender, e);
        }


    }
}
