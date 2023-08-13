namespace Assignment_1
{
    partial class FinalScore
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
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.btnFinalScoreOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.Location = new System.Drawing.Point(29, 25);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(125, 96);
            this.lblFinalScore.TabIndex = 0;
            this.lblFinalScore.Text = "GAME OVER\r\n\r\nYour Score:\r\n0\r\n";
            this.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFinalScoreOK
            // 
            this.btnFinalScoreOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalScoreOK.Location = new System.Drawing.Point(40, 137);
            this.btnFinalScoreOK.Name = "btnFinalScoreOK";
            this.btnFinalScoreOK.Size = new System.Drawing.Size(100, 30);
            this.btnFinalScoreOK.TabIndex = 1;
            this.btnFinalScoreOK.Text = "OK";
            this.btnFinalScoreOK.UseVisualStyleBackColor = true;
            this.btnFinalScoreOK.Click += new System.EventHandler(this.btnFinalScoreOK_Click);
            // 
            // FinalScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 186);
            this.Controls.Add(this.btnFinalScoreOK);
            this.Controls.Add(this.lblFinalScore);
            this.MaximumSize = new System.Drawing.Size(200, 225);
            this.MinimumSize = new System.Drawing.Size(200, 225);
            this.Name = "FinalScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FinalScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Button btnFinalScoreOK;
    }
}