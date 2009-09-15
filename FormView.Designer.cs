namespace Плавающие_фигуры
{
    partial class FormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.addRemoveGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfShapeToRemoveNumeric = new System.Windows.Forms.NumericUpDown();
            this.addRectangleButton = new System.Windows.Forms.Button();
            this.addSquareButton = new System.Windows.Forms.Button();
            this.addTriangleButton = new System.Windows.Forms.Button();
            this.addCircleButton = new System.Windows.Forms.Button();
            this.removeShapeButton = new System.Windows.Forms.Button();
            this.newShapeSizePanel = new System.Windows.Forms.Panel();
            this.sizeVariable2Numeric = new System.Windows.Forms.NumericUpDown();
            this.sizeVariable1Numeric = new System.Windows.Forms.NumericUpDown();
            this.sizeVariable2DescriptionLabel = new System.Windows.Forms.Label();
            this.sizeVariable1DescriptionLabel = new System.Windows.Forms.Label();
            this.numberOfShapesGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfShapesLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numbeerOfSquaresLabel = new System.Windows.Forms.Label();
            this.numberOfRectanglesLabel = new System.Windows.Forms.Label();
            this.numberOfTrianglesLabel = new System.Windows.Forms.Label();
            this.numberOfCirclesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.motionControlGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MQTrackBar = new System.Windows.Forms.TrackBar();
            this.RFTrackbar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.drawTailsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainControlsGroupBox.SuspendLayout();
            this.addRemoveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfShapeToRemoveNumeric)).BeginInit();
            this.newShapeSizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeVariable2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeVariable1Numeric)).BeginInit();
            this.numberOfShapesGroupBox.SuspendLayout();
            this.motionControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MQTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RFTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainControlsGroupBox
            // 
            this.mainControlsGroupBox.Controls.Add(this.stopButton);
            this.mainControlsGroupBox.Controls.Add(this.pauseButton);
            this.mainControlsGroupBox.Controls.Add(this.startButton);
            this.mainControlsGroupBox.Location = new System.Drawing.Point(520, 12);
            this.mainControlsGroupBox.Name = "mainControlsGroupBox";
            this.mainControlsGroupBox.Size = new System.Drawing.Size(213, 42);
            this.mainControlsGroupBox.TabIndex = 1;
            this.mainControlsGroupBox.TabStop = false;
            this.mainControlsGroupBox.Text = "Основные действия";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(157, 16);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(50, 20);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(84, 16);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(50, 20);
            this.pauseButton.TabIndex = 0;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 16);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(50, 20);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // addRemoveGroupBox
            // 
            this.addRemoveGroupBox.Controls.Add(this.numberOfShapeToRemoveNumeric);
            this.addRemoveGroupBox.Controls.Add(this.addRectangleButton);
            this.addRemoveGroupBox.Controls.Add(this.addSquareButton);
            this.addRemoveGroupBox.Controls.Add(this.addTriangleButton);
            this.addRemoveGroupBox.Controls.Add(this.addCircleButton);
            this.addRemoveGroupBox.Controls.Add(this.removeShapeButton);
            this.addRemoveGroupBox.Location = new System.Drawing.Point(520, 60);
            this.addRemoveGroupBox.Name = "addRemoveGroupBox";
            this.addRemoveGroupBox.Size = new System.Drawing.Size(213, 101);
            this.addRemoveGroupBox.TabIndex = 2;
            this.addRemoveGroupBox.TabStop = false;
            this.addRemoveGroupBox.Text = "Управление фигурами";
            // 
            // numberOfShapeToRemoveNumeric
            // 
            this.numberOfShapeToRemoveNumeric.Location = new System.Drawing.Point(164, 21);
            this.numberOfShapeToRemoveNumeric.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numberOfShapeToRemoveNumeric.Name = "numberOfShapeToRemoveNumeric";
            this.numberOfShapeToRemoveNumeric.Size = new System.Drawing.Size(43, 20);
            this.numberOfShapeToRemoveNumeric.TabIndex = 3;
            // 
            // addRectangleButton
            // 
            this.addRectangleButton.Location = new System.Drawing.Point(99, 73);
            this.addRectangleButton.Name = "addRectangleButton";
            this.addRectangleButton.Size = new System.Drawing.Size(108, 23);
            this.addRectangleButton.TabIndex = 2;
            this.addRectangleButton.Text = "+Прямоугольник";
            this.addRectangleButton.UseVisualStyleBackColor = true;
            this.addRectangleButton.Click += new System.EventHandler(this.addRectangleButton_Click);
            // 
            // addSquareButton
            // 
            this.addSquareButton.Location = new System.Drawing.Point(6, 73);
            this.addSquareButton.Name = "addSquareButton";
            this.addSquareButton.Size = new System.Drawing.Size(87, 23);
            this.addSquareButton.TabIndex = 2;
            this.addSquareButton.Text = "+Квадрат";
            this.addSquareButton.UseVisualStyleBackColor = true;
            this.addSquareButton.Click += new System.EventHandler(this.addSquareButton_Click);
            // 
            // addTriangleButton
            // 
            this.addTriangleButton.Location = new System.Drawing.Point(99, 49);
            this.addTriangleButton.Name = "addTriangleButton";
            this.addTriangleButton.Size = new System.Drawing.Size(108, 23);
            this.addTriangleButton.TabIndex = 2;
            this.addTriangleButton.Text = "+Треугольник";
            this.addTriangleButton.UseVisualStyleBackColor = true;
            this.addTriangleButton.Click += new System.EventHandler(this.addTriangleButton_Click);
            // 
            // addCircleButton
            // 
            this.addCircleButton.Location = new System.Drawing.Point(7, 49);
            this.addCircleButton.Name = "addCircleButton";
            this.addCircleButton.Size = new System.Drawing.Size(86, 23);
            this.addCircleButton.TabIndex = 2;
            this.addCircleButton.Text = "+Круг";
            this.addCircleButton.UseVisualStyleBackColor = true;
            this.addCircleButton.Click += new System.EventHandler(this.addCircleButton_Click);
            // 
            // removeShapeButton
            // 
            this.removeShapeButton.Location = new System.Drawing.Point(6, 19);
            this.removeShapeButton.Name = "removeShapeButton";
            this.removeShapeButton.Size = new System.Drawing.Size(151, 23);
            this.removeShapeButton.TabIndex = 0;
            this.removeShapeButton.Text = "Удалить фигуру №";
            this.removeShapeButton.UseVisualStyleBackColor = true;
            this.removeShapeButton.Click += new System.EventHandler(this.removeShapeButton_Click);
            // 
            // newShapeSizePanel
            // 
            this.newShapeSizePanel.Controls.Add(this.sizeVariable2Numeric);
            this.newShapeSizePanel.Controls.Add(this.sizeVariable1Numeric);
            this.newShapeSizePanel.Controls.Add(this.sizeVariable2DescriptionLabel);
            this.newShapeSizePanel.Controls.Add(this.sizeVariable1DescriptionLabel);
            this.newShapeSizePanel.Location = new System.Drawing.Point(520, 168);
            this.newShapeSizePanel.Name = "newShapeSizePanel";
            this.newShapeSizePanel.Size = new System.Drawing.Size(213, 68);
            this.newShapeSizePanel.TabIndex = 3;
            // 
            // sizeVariable2Numeric
            // 
            this.sizeVariable2Numeric.Location = new System.Drawing.Point(157, 36);
            this.sizeVariable2Numeric.Name = "sizeVariable2Numeric";
            this.sizeVariable2Numeric.Size = new System.Drawing.Size(46, 20);
            this.sizeVariable2Numeric.TabIndex = 2;
            // 
            // sizeVariable1Numeric
            // 
            this.sizeVariable1Numeric.Location = new System.Drawing.Point(157, 3);
            this.sizeVariable1Numeric.Name = "sizeVariable1Numeric";
            this.sizeVariable1Numeric.Size = new System.Drawing.Size(46, 20);
            this.sizeVariable1Numeric.TabIndex = 2;
            // 
            // sizeVariable2DescriptionLabel
            // 
            this.sizeVariable2DescriptionLabel.AutoSize = true;
            this.sizeVariable2DescriptionLabel.Location = new System.Drawing.Point(4, 43);
            this.sizeVariable2DescriptionLabel.Name = "sizeVariable2DescriptionLabel";
            this.sizeVariable2DescriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.sizeVariable2DescriptionLabel.TabIndex = 1;
            this.sizeVariable2DescriptionLabel.Text = "label2";
            // 
            // sizeVariable1DescriptionLabel
            // 
            this.sizeVariable1DescriptionLabel.AutoSize = true;
            this.sizeVariable1DescriptionLabel.Location = new System.Drawing.Point(4, 5);
            this.sizeVariable1DescriptionLabel.Name = "sizeVariable1DescriptionLabel";
            this.sizeVariable1DescriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.sizeVariable1DescriptionLabel.TabIndex = 0;
            this.sizeVariable1DescriptionLabel.Text = "label1";
            // 
            // numberOfShapesGroupBox
            // 
            this.numberOfShapesGroupBox.Controls.Add(this.numberOfShapesLabel);
            this.numberOfShapesGroupBox.Controls.Add(this.label5);
            this.numberOfShapesGroupBox.Controls.Add(this.numbeerOfSquaresLabel);
            this.numberOfShapesGroupBox.Controls.Add(this.numberOfRectanglesLabel);
            this.numberOfShapesGroupBox.Controls.Add(this.numberOfTrianglesLabel);
            this.numberOfShapesGroupBox.Controls.Add(this.numberOfCirclesLabel);
            this.numberOfShapesGroupBox.Controls.Add(this.label4);
            this.numberOfShapesGroupBox.Controls.Add(this.label3);
            this.numberOfShapesGroupBox.Controls.Add(this.label2);
            this.numberOfShapesGroupBox.Controls.Add(this.label1);
            this.numberOfShapesGroupBox.Location = new System.Drawing.Point(520, 389);
            this.numberOfShapesGroupBox.Name = "numberOfShapesGroupBox";
            this.numberOfShapesGroupBox.Size = new System.Drawing.Size(213, 118);
            this.numberOfShapesGroupBox.TabIndex = 4;
            this.numberOfShapesGroupBox.TabStop = false;
            this.numberOfShapesGroupBox.Text = "Количество существующих фигур";
            // 
            // numberOfShapesLabel
            // 
            this.numberOfShapesLabel.AutoSize = true;
            this.numberOfShapesLabel.Location = new System.Drawing.Point(86, 99);
            this.numberOfShapesLabel.Name = "numberOfShapesLabel";
            this.numberOfShapesLabel.Size = new System.Drawing.Size(35, 13);
            this.numberOfShapesLabel.TabIndex = 6;
            this.numberOfShapesLabel.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Всего фигур:";
            // 
            // numbeerOfSquaresLabel
            // 
            this.numbeerOfSquaresLabel.AutoSize = true;
            this.numbeerOfSquaresLabel.Location = new System.Drawing.Point(128, 74);
            this.numbeerOfSquaresLabel.Name = "numbeerOfSquaresLabel";
            this.numbeerOfSquaresLabel.Size = new System.Drawing.Size(35, 13);
            this.numbeerOfSquaresLabel.TabIndex = 4;
            this.numbeerOfSquaresLabel.Text = "label5";
            // 
            // numberOfRectanglesLabel
            // 
            this.numberOfRectanglesLabel.AutoSize = true;
            this.numberOfRectanglesLabel.Location = new System.Drawing.Point(117, 52);
            this.numberOfRectanglesLabel.Name = "numberOfRectanglesLabel";
            this.numberOfRectanglesLabel.Size = new System.Drawing.Size(35, 13);
            this.numberOfRectanglesLabel.TabIndex = 4;
            this.numberOfRectanglesLabel.Text = "label5";
            // 
            // numberOfTrianglesLabel
            // 
            this.numberOfTrianglesLabel.AutoSize = true;
            this.numberOfTrianglesLabel.Location = new System.Drawing.Point(168, 25);
            this.numberOfTrianglesLabel.Name = "numberOfTrianglesLabel";
            this.numberOfTrianglesLabel.Size = new System.Drawing.Size(35, 13);
            this.numberOfTrianglesLabel.TabIndex = 4;
            this.numberOfTrianglesLabel.Text = "label5";
            // 
            // numberOfCirclesLabel
            // 
            this.numberOfCirclesLabel.AutoSize = true;
            this.numberOfCirclesLabel.Location = new System.Drawing.Point(49, 25);
            this.numberOfCirclesLabel.Name = "numberOfCirclesLabel";
            this.numberOfCirclesLabel.Size = new System.Drawing.Size(35, 13);
            this.numberOfCirclesLabel.TabIndex = 4;
            this.numberOfCirclesLabel.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Из них квадратов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Прямоугольников:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Треугольников:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кругов:";
            // 
            // motionControlGroupBox
            // 
            this.motionControlGroupBox.Controls.Add(this.drawTailsCheckBox);
            this.motionControlGroupBox.Controls.Add(this.label7);
            this.motionControlGroupBox.Controls.Add(this.RFTrackbar);
            this.motionControlGroupBox.Controls.Add(this.MQTrackBar);
            this.motionControlGroupBox.Controls.Add(this.label6);
            this.motionControlGroupBox.Location = new System.Drawing.Point(520, 242);
            this.motionControlGroupBox.Name = "motionControlGroupBox";
            this.motionControlGroupBox.Size = new System.Drawing.Size(213, 141);
            this.motionControlGroupBox.TabIndex = 5;
            this.motionControlGroupBox.TabStop = false;
            this.motionControlGroupBox.Text = "Управление движением";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Коэффициент макс. смещения:";
            // 
            // MQTrackBar
            // 
            this.MQTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MQTrackBar.Location = new System.Drawing.Point(6, 36);
            this.MQTrackBar.Maximum = 40;
            this.MQTrackBar.Minimum = 1;
            this.MQTrackBar.Name = "MQTrackBar";
            this.MQTrackBar.Size = new System.Drawing.Size(191, 37);
            this.MQTrackBar.TabIndex = 2;
            this.MQTrackBar.Value = 5;
            // 
            // RFTrackbar
            // 
            this.RFTrackbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RFTrackbar.Location = new System.Drawing.Point(6, 79);
            this.RFTrackbar.Maximum = 33;
            this.RFTrackbar.Minimum = 1;
            this.RFTrackbar.Name = "RFTrackbar";
            this.RFTrackbar.Size = new System.Drawing.Size(196, 37);
            this.RFTrackbar.TabIndex = 2;
            this.RFTrackbar.Value = 4;
            this.RFTrackbar.ValueChanged += new System.EventHandler(this.RFTrackbar_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Частота обновления: ";
            // 
            // drawTailsCheckBox
            // 
            this.drawTailsCheckBox.AutoSize = true;
            this.drawTailsCheckBox.Location = new System.Drawing.Point(12, 118);
            this.drawTailsCheckBox.Name = "drawTailsCheckBox";
            this.drawTailsCheckBox.Size = new System.Drawing.Size(119, 17);
            this.drawTailsCheckBox.TabIndex = 5;
            this.drawTailsCheckBox.Text = "Рисовать \"следы\"";
            this.drawTailsCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 524);
            this.Controls.Add(this.motionControlGroupBox);
            this.Controls.Add(this.numberOfShapesGroupBox);
            this.Controls.Add(this.newShapeSizePanel);
            this.Controls.Add(this.addRemoveGroupBox);
            this.Controls.Add(this.mainControlsGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainControlsGroupBox.ResumeLayout(false);
            this.addRemoveGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfShapeToRemoveNumeric)).EndInit();
            this.newShapeSizePanel.ResumeLayout(false);
            this.newShapeSizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeVariable2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeVariable1Numeric)).EndInit();
            this.numberOfShapesGroupBox.ResumeLayout(false);
            this.numberOfShapesGroupBox.PerformLayout();
            this.motionControlGroupBox.ResumeLayout(false);
            this.motionControlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MQTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RFTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox mainControlsGroupBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.GroupBox addRemoveGroupBox;
        private System.Windows.Forms.Button removeShapeButton;
        private System.Windows.Forms.Button addRectangleButton;
        private System.Windows.Forms.Button addSquareButton;
        private System.Windows.Forms.Button addTriangleButton;
        private System.Windows.Forms.Button addCircleButton;
        private System.Windows.Forms.NumericUpDown numberOfShapeToRemoveNumeric;
        private System.Windows.Forms.Panel newShapeSizePanel;
        private System.Windows.Forms.NumericUpDown sizeVariable2Numeric;
        private System.Windows.Forms.NumericUpDown sizeVariable1Numeric;
        private System.Windows.Forms.Label sizeVariable2DescriptionLabel;
        private System.Windows.Forms.Label sizeVariable1DescriptionLabel;
        private System.Windows.Forms.GroupBox numberOfShapesGroupBox;
        private System.Windows.Forms.Label numbeerOfSquaresLabel;
        private System.Windows.Forms.Label numberOfRectanglesLabel;
        private System.Windows.Forms.Label numberOfTrianglesLabel;
        private System.Windows.Forms.Label numberOfCirclesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfShapesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox motionControlGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar RFTrackbar;
        private System.Windows.Forms.TrackBar MQTrackBar;
        private System.Windows.Forms.CheckBox drawTailsCheckBox;
    }
}

