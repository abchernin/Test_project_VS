using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ПлавающиеФигуры.Engine;

//ASDFASDF Q3WR4FASDFV Q24TASDF Q243RFTA SFV
namespace Плавающие_фигуры
{
    static class Program
    {

        // Параметры поля
        const int AREA_HEIGHT = 500;
        const int AREA_WIDTH = 500;
        const int AREA_OFFSET = 50;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Creating new MVC triplet
            Model model = new Model(); //The model
            FormView mainView = new FormView(model, AREA_WIDTH, AREA_HEIGHT, AREA_OFFSET); // The view
            Presenter presenter = new Presenter(model, mainView, AREA_WIDTH, AREA_HEIGHT, AREA_OFFSET); // The presenter
            // Running the app
            Application.Run(mainView);
        }
    }
}
