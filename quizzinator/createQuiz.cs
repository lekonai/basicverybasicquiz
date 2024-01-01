using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace quizzinator
{
    public partial class createQuiz : Form
    {
        public createQuiz()
        {
            InitializeComponent();
        }

        private void quizNameGroup_Enter(object sender, EventArgs e)
        {

        }

        private void qNumText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quizQuestionsG_Enter(object sender, EventArgs e)
        {

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Forms.mm.Show();
            this.Hide();
        }

        private void addQButton_Click(object sender, EventArgs e)
        {
            string filename = quizNameText.Text;
            bool append = true;

            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(qNumText.Text);
                sw.WriteLine(qText.Text);
                sw.WriteLine(ansA.Text);
                sw.WriteLine(ansB.Text);
                sw.WriteLine(ansC.Text);
                sw.WriteLine(ansD.Text);
                sw.WriteLine(correctAns.Text);

            }
            MessageBox.Show("YAY! Question added");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            qText.Clear();
            qNumText.Clear();
            ansA.Clear();
            ansB.Clear();
            ansC.Clear();
            ansD.Clear();

            correctAns.SelectedIndex = -1;
        }
    }
}
