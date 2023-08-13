namespace Assignment_1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblRules = new System.Windows.Forms.Label();
            this.btnRulesClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(129, 118);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(300, 200);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnColor_OnClick);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Maroon;
            this.btnRed.Location = new System.Drawing.Point(435, 118);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(300, 200);
            this.btnRed.TabIndex = 1;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnColor_OnClick);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Teal;
            this.btnBlue.Location = new System.Drawing.Point(129, 324);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(300, 200);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnColor_OnClick);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYellow.Location = new System.Drawing.Point(435, 324);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(300, 200);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnColor_OnClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(317, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 73);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "SIMON";
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.ForeColor = System.Drawing.Color.White;
            this.lblCurrentScore.Location = new System.Drawing.Point(47, 66);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(169, 25);
            this.lblCurrentScore.TabIndex = 5;
            this.lblCurrentScore.Text = "Current Score: 0";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.White;
            this.lblHighScore.Location = new System.Drawing.Point(687, 66);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(142, 25);
            this.lblHighScore.TabIndex = 6;
            this.lblHighScore.Text = "High Score: 0";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(847, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_OnClick);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.White;
            this.lblRules.Location = new System.Drawing.Point(71, 157);
            this.lblRules.Name = "lblRules";
            this.lblRules.Padding = new System.Windows.Forms.Padding(20, 25, 20, 100);
            this.lblRules.Size = new System.Drawing.Size(735, 327);
            this.lblRules.TabIndex = 8;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            this.lblRules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRulesClose
            // 
            this.btnRulesClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRulesClose.Location = new System.Drawing.Point(385, 426);
            this.btnRulesClose.Name = "btnRulesClose";
            this.btnRulesClose.Size = new System.Drawing.Size(100, 30);
            this.btnRulesClose.TabIndex = 9;
            this.btnRulesClose.Text = "Close";
            this.btnRulesClose.UseVisualStyleBackColor = true;
            this.btnRulesClose.Click += new System.EventHandler(this.btnRulesClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnRulesClose);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGreen);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnRulesClose;
    }
}

