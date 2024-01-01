
namespace quizzinator
{
    partial class playQuiz
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
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.fileNameButton = new System.Windows.Forms.Button();
            this.checkAnsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(454, 23);
            this.fileNameTextBox.TabIndex = 0;
            // 
            // fileNameButton
            // 
            this.fileNameButton.Location = new System.Drawing.Point(473, 12);
            this.fileNameButton.Name = "fileNameButton";
            this.fileNameButton.Size = new System.Drawing.Size(276, 23);
            this.fileNameButton.TabIndex = 1;
            this.fileNameButton.Text = "Enter File Name";
            this.fileNameButton.UseVisualStyleBackColor = true;
            this.fileNameButton.Click += new System.EventHandler(this.fileNameButton_Click);
            // 
            // checkAnsButton
            // 
            this.checkAnsButton.Location = new System.Drawing.Point(795, 474);
            this.checkAnsButton.Name = "checkAnsButton";
            this.checkAnsButton.Size = new System.Drawing.Size(126, 33);
            this.checkAnsButton.TabIndex = 2;
            this.checkAnsButton.Text = "Check The Answers";
            this.checkAnsButton.UseVisualStyleBackColor = true;
            this.checkAnsButton.Visible = false;
            this.checkAnsButton.Click += new System.EventHandler(this.checkAnsButton_Click);
            // 
            // playQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.checkAnsButton);
            this.Controls.Add(this.fileNameButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "playQuiz";
            this.Text = "Quiz Time!";
            this.Load += new System.EventHandler(this.playQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button fileNameButton;
        private System.Windows.Forms.Button checkAnsButton;
    }
}