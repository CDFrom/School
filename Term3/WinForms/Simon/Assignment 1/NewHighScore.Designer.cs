namespace Assignment_1
{
    partial class NewHighScore
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
            this.lblNewHighScore = new System.Windows.Forms.Label();
            this.txtBoxNewHighScore = new System.Windows.Forms.TextBox();
            this.lblInitials = new System.Windows.Forms.Label();
            this.btnNewHighScoreEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewHighScore
            // 
            this.lblNewHighScore.AutoSize = true;
            this.lblNewHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewHighScore.Location = new System.Drawing.Point(56, 9);
            this.lblNewHighScore.Name = "lblNewHighScore";
            this.lblNewHighScore.Size = new System.Drawing.Size(178, 25);
            this.lblNewHighScore.TabIndex = 0;
            this.lblNewHighScore.Text = "New High Score!!";
            // 
            // txtBoxNewHighScore
            // 
            this.txtBoxNewHighScore.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxNewHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewHighScore.Location = new System.Drawing.Point(70, 71);
            this.txtBoxNewHighScore.MaxLength = 3;
            this.txtBoxNewHighScore.Name = "txtBoxNewHighScore";
            this.txtBoxNewHighScore.Size = new System.Drawing.Size(150, 29);
            this.txtBoxNewHighScore.TabIndex = 1;
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitials.Location = new System.Drawing.Point(117, 48);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(54, 20);
            this.lblInitials.TabIndex = 2;
            this.lblInitials.Text = "Initials";
            // 
            // btnNewHighScoreEnter
            // 
            this.btnNewHighScoreEnter.Location = new System.Drawing.Point(96, 119);
            this.btnNewHighScoreEnter.Name = "btnNewHighScoreEnter";
            this.btnNewHighScoreEnter.Size = new System.Drawing.Size(100, 30);
            this.btnNewHighScoreEnter.TabIndex = 3;
            this.btnNewHighScoreEnter.Text = "Enter";
            this.btnNewHighScoreEnter.UseVisualStyleBackColor = true;
            this.btnNewHighScoreEnter.Click += new System.EventHandler(this.btnNewHighScoreEnter_Click);
            // 
            // NewHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnNewHighScoreEnter);
            this.Controls.Add(this.lblInitials);
            this.Controls.Add(this.txtBoxNewHighScore);
            this.Controls.Add(this.lblNewHighScore);
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "NewHighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewHighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewHighScore;
        private System.Windows.Forms.TextBox txtBoxNewHighScore;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.Button btnNewHighScoreEnter;
    }
}