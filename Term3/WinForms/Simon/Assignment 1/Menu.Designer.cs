namespace Assignment_1
{
    partial class menu
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(41, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "New Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(41, 51);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(100, 40);
            this.btnScores.TabIndex = 1;
            this.btnScores.Text = "Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(41, 97);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(100, 40);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(41, 143);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 40);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 186);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnPlay);
            this.MaximumSize = new System.Drawing.Size(200, 225);
            this.MinimumSize = new System.Drawing.Size(200, 225);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnQuit;
    }
}