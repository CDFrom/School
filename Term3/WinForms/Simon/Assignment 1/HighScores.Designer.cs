namespace Assignment_1
{
    partial class HighScores
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
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lblTitleHighScores = new System.Windows.Forms.Label();
            this.btnHighScoresOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHighScores
            // 
            this.lblHighScores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScores.Location = new System.Drawing.Point(73, 77);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(131, 145);
            this.lblHighScores.TabIndex = 0;
            this.lblHighScores.Text = "AAA          0\r\nAAA          0\r\nAAA          0\r\nAAA          0\r\nAAA          0";
            this.lblHighScores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitleHighScores
            // 
            this.lblTitleHighScores.AutoSize = true;
            this.lblTitleHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHighScores.Location = new System.Drawing.Point(38, 21);
            this.lblTitleHighScores.Name = "lblTitleHighScores";
            this.lblTitleHighScores.Size = new System.Drawing.Size(213, 31);
            this.lblTitleHighScores.TabIndex = 1;
            this.lblTitleHighScores.Text = "HIGH SCORES:";
            // 
            // btnHighScoresOK
            // 
            this.btnHighScoresOK.Location = new System.Drawing.Point(75, 244);
            this.btnHighScoresOK.Name = "btnHighScoresOK";
            this.btnHighScoresOK.Size = new System.Drawing.Size(125, 40);
            this.btnHighScoresOK.TabIndex = 2;
            this.btnHighScoresOK.Text = "OK";
            this.btnHighScoresOK.UseVisualStyleBackColor = true;
            this.btnHighScoresOK.Click += new System.EventHandler(this.btnHighScoresOK_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.btnHighScoresOK);
            this.Controls.Add(this.lblTitleHighScores);
            this.Controls.Add(this.lblHighScores);
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "HighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Label lblTitleHighScores;
        private System.Windows.Forms.Button btnHighScoresOK;
    }
}