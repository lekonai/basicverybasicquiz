using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizzinator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
    static class Forms 
    { 
        public static MainMenu mm = new MainMenu();
        public static createQuiz cQ = new createQuiz();
        public static playQuiz pQ = new playQuiz();

    }

}
