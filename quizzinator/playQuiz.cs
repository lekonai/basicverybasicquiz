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
    public partial class playQuiz : Form
    {

        public struct quizQuestions
        {
            public int qNumber;
            public string question;
            public string a;
            public string b;
            public string c;
            public string d;
            public char correctAnswer;
        }

        public List<quizQuestions> theQuiz = new List<quizQuestions>();
        public List<GroupBox> quizSections = new List<GroupBox>();

        public playQuiz()
        {
            InitializeComponent();
        }

        private void playQuiz_Load(object sender, EventArgs e)
        {

        }

        private void fileNameButton_Click(object sender, EventArgs e)
        {
            string fileName = fileNameTextBox.Text;
            quizQuestions tempques;
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    tempques.qNumber = int.Parse(sr.ReadLine());
                    tempques.question = sr.ReadLine();
                    tempques.a = sr.ReadLine();
                    tempques.b = sr.ReadLine();
                    tempques.c = sr.ReadLine();
                    tempques.d = sr.ReadLine();
                    tempques.correctAnswer = char.Parse(sr.ReadLine());

                    theQuiz.Add(tempques);
                }
            }

            fileNameTextBox.Visible = false;
            fileNameButton.Visible = false;
            checkAnsButton.Visible = true;

            int count = 0;
            int locationVar = 0;
            foreach (quizQuestions i in theQuiz)
            {
                GroupBox g = new GroupBox();
                g.Name = "g" + count;
                g.BackColor = Color.DarkRed;
                g.ForeColor = Color.White;
                g.Text = "Question" + count;
                g.Location = new Point(10, 30 + locationVar);
                g.Size = new Size(360, 150);

                quizSections.Add(g);

                count += 1;
                locationVar += 250;
            }

            foreach (quizQuestions i in theQuiz)
            {
                Label l = new Label();
                l.Name = i.qNumber + "label";
                l.Text = i.question;
                l.Location = new Point(15, 15);
                l.Size = new Size(300, 60);
                l.Font = new Font("Comic Sans MS", 11);
                l.BorderStyle = BorderStyle.FixedSingle;
                quizSections[i.qNumber - 1].Controls.Add(l);
                this.Controls.Add(quizSections[i.qNumber - 1]);

                Label a = new Label();
                a.Name = "Answer Label" + i.qNumber;
                a.Text = "Answer";
                a.Location = new Point(15, 90);
                a.Font = new Font("Comic Sans MS", 11);
                quizSections[i.qNumber - 1].Controls.Add(l);
                this.Controls.Add(quizSections[i.qNumber - 1]);

                ComboBox c = new ComboBox();
                c.Name = i.qNumber + "combo";
                c.Location = new Point(125, 90);
                c.Font = new Font("Comic Sans MS", 11);
                c.Items.Add(i.a);
                c.Items.Add(i.b);
                c.Items.Add(i.c);
                c.Items.Add(i.d);
                quizSections[i.qNumber - 1].Controls.Add(c);
                this.Controls.Add(quizSections[i.qNumber - 1]);

            }
        }

        private void checkAnsButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            int score = 0; 
            foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
            {
                foreach (ComboBox cb in gb.Controls.OfType<ComboBox>())
                {
                    if (cb.SelectedIndex == ((int)(theQuiz[count].correctAnswer)) - 97)
                    {
                        score += 1;
                    }
                    count++;
                }
            }
            MessageBox.Show("Your score is " + score);
        }
    }
}
