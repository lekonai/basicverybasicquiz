
namespace quizzinator
{
    partial class createQuiz
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
            this.quizNameGroup = new System.Windows.Forms.GroupBox();
            this.quizQuestionsG = new System.Windows.Forms.GroupBox();
            this.quizNameText = new System.Windows.Forms.TextBox();
            this.qNumText = new System.Windows.Forms.TextBox();
            this.qNameLBL = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.Label();
            this.qText = new System.Windows.Forms.TextBox();
            this.ans = new System.Windows.Forms.Label();
            this.choices = new System.Windows.Forms.Label();
            this.ansA = new System.Windows.Forms.TextBox();
            this.ansB = new System.Windows.Forms.TextBox();
            this.ansC = new System.Windows.Forms.TextBox();
            this.ansD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.correctAns = new System.Windows.Forms.ComboBox();
            this.addQButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.quizNameGroup.SuspendLayout();
            this.quizQuestionsG.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizNameGroup
            // 
            this.quizNameGroup.Controls.Add(this.quizNameText);
            this.quizNameGroup.Location = new System.Drawing.Point(12, 12);
            this.quizNameGroup.Name = "quizNameGroup";
            this.quizNameGroup.Size = new System.Drawing.Size(483, 94);
            this.quizNameGroup.TabIndex = 0;
            this.quizNameGroup.TabStop = false;
            this.quizNameGroup.Text = "Quiz Name";
            this.quizNameGroup.Enter += new System.EventHandler(this.quizNameGroup_Enter);
            // 
            // quizQuestionsG
            // 
            this.quizQuestionsG.Controls.Add(this.correctAns);
            this.quizQuestionsG.Controls.Add(this.label1);
            this.quizQuestionsG.Controls.Add(this.ansD);
            this.quizQuestionsG.Controls.Add(this.ansC);
            this.quizQuestionsG.Controls.Add(this.ansB);
            this.quizQuestionsG.Controls.Add(this.ansA);
            this.quizQuestionsG.Controls.Add(this.choices);
            this.quizQuestionsG.Controls.Add(this.ans);
            this.quizQuestionsG.Controls.Add(this.qText);
            this.quizQuestionsG.Controls.Add(this.q);
            this.quizQuestionsG.Controls.Add(this.qNameLBL);
            this.quizQuestionsG.Controls.Add(this.qNumText);
            this.quizQuestionsG.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizQuestionsG.Location = new System.Drawing.Point(12, 112);
            this.quizQuestionsG.Name = "quizQuestionsG";
            this.quizQuestionsG.Size = new System.Drawing.Size(932, 302);
            this.quizQuestionsG.TabIndex = 1;
            this.quizQuestionsG.TabStop = false;
            this.quizQuestionsG.Text = "Questions";
            this.quizQuestionsG.Enter += new System.EventHandler(this.quizQuestionsG_Enter);
            // 
            // quizNameText
            // 
            this.quizNameText.Location = new System.Drawing.Point(6, 38);
            this.quizNameText.Name = "quizNameText";
            this.quizNameText.Size = new System.Drawing.Size(470, 23);
            this.quizNameText.TabIndex = 0;
            // 
            // qNumText
            // 
            this.qNumText.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qNumText.Location = new System.Drawing.Point(153, 22);
            this.qNumText.Name = "qNumText";
            this.qNumText.Size = new System.Drawing.Size(52, 27);
            this.qNumText.TabIndex = 0;
            this.qNumText.TextChanged += new System.EventHandler(this.qNumText_TextChanged);
            // 
            // qNameLBL
            // 
            this.qNameLBL.AutoSize = true;
            this.qNameLBL.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qNameLBL.Location = new System.Drawing.Point(23, 25);
            this.qNameLBL.Name = "qNameLBL";
            this.qNameLBL.Size = new System.Drawing.Size(128, 19);
            this.qNameLBL.TabIndex = 1;
            this.qNameLBL.Text = "Question Number:";
            this.qNameLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Location = new System.Drawing.Point(79, 59);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(72, 19);
            this.q.TabIndex = 2;
            this.q.Text = "Question:";
            // 
            // qText
            // 
            this.qText.Location = new System.Drawing.Point(153, 56);
            this.qText.Name = "qText";
            this.qText.Size = new System.Drawing.Size(773, 27);
            this.qText.TabIndex = 3;
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(83, 94);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(68, 19);
            this.ans.TabIndex = 4;
            this.ans.Text = "Answers:";
            // 
            // choices
            // 
            this.choices.AutoSize = true;
            this.choices.Location = new System.Drawing.Point(157, 94);
            this.choices.Name = "choices";
            this.choices.Size = new System.Drawing.Size(17, 133);
            this.choices.TabIndex = 5;
            this.choices.Text = "a\r\n\r\nb\r\n\r\nc\r\n\r\nd";
            // 
            // ansA
            // 
            this.ansA.Location = new System.Drawing.Point(180, 91);
            this.ansA.Name = "ansA";
            this.ansA.Size = new System.Drawing.Size(746, 27);
            this.ansA.TabIndex = 6;
            // 
            // ansB
            // 
            this.ansB.Location = new System.Drawing.Point(180, 129);
            this.ansB.Name = "ansB";
            this.ansB.Size = new System.Drawing.Size(746, 27);
            this.ansB.TabIndex = 7;
            // 
            // ansC
            // 
            this.ansC.Location = new System.Drawing.Point(180, 166);
            this.ansC.Name = "ansC";
            this.ansC.Size = new System.Drawing.Size(746, 27);
            this.ansC.TabIndex = 8;
            // 
            // ansD
            // 
            this.ansD.Location = new System.Drawing.Point(180, 206);
            this.ansD.Name = "ansD";
            this.ansD.Size = new System.Drawing.Size(746, 27);
            this.ansD.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Which is correct?:";
            // 
            // correctAns
            // 
            this.correctAns.FormattingEnabled = true;
            this.correctAns.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.correctAns.Location = new System.Drawing.Point(153, 259);
            this.correctAns.Name = "correctAns";
            this.correctAns.Size = new System.Drawing.Size(52, 27);
            this.correctAns.TabIndex = 11;
            // 
            // addQButton
            // 
            this.addQButton.Location = new System.Drawing.Point(18, 621);
            this.addQButton.Name = "addQButton";
            this.addQButton.Size = new System.Drawing.Size(168, 34);
            this.addQButton.TabIndex = 12;
            this.addQButton.Text = "Add Question";
            this.addQButton.UseVisualStyleBackColor = true;
            this.addQButton.Click += new System.EventHandler(this.addQButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(192, 621);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(168, 34);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(776, 621);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(168, 34);
            this.mainMenuButton.TabIndex = 14;
            this.mainMenuButton.Text = "Back To The Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // createQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 667);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addQButton);
            this.Controls.Add(this.quizQuestionsG);
            this.Controls.Add(this.quizNameGroup);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "createQuiz";
            this.Text = "Quiz Creator!";
            this.quizNameGroup.ResumeLayout(false);
            this.quizNameGroup.PerformLayout();
            this.quizQuestionsG.ResumeLayout(false);
            this.quizQuestionsG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox quizNameGroup;
        private System.Windows.Forms.TextBox quizNameText;
        private System.Windows.Forms.GroupBox quizQuestionsG;
        private System.Windows.Forms.Label qNameLBL;
        private System.Windows.Forms.TextBox qNumText;
        private System.Windows.Forms.ComboBox correctAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ansD;
        private System.Windows.Forms.TextBox ansC;
        private System.Windows.Forms.TextBox ansB;
        private System.Windows.Forms.TextBox ansA;
        private System.Windows.Forms.Label choices;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.TextBox qText;
        private System.Windows.Forms.Label q;
        private System.Windows.Forms.Button addQButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button mainMenuButton;
    }
}