namespace Assignment2
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
            this.extraControls = new Assignment2.ExtraControls();
            this.userInput = new Assignment2.UserInput();
            this.pieChart = new Assignment2.PieChart();
            this.colorSelect = new Assignment2.ColorSelect();
            this.legend = new Assignment2.Legend();
            this.SuspendLayout();
            // 
            // extraControls
            // 
            this.extraControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraControls.Location = new System.Drawing.Point(624, 392);
            this.extraControls.Name = "extraControls";
            this.extraControls.Size = new System.Drawing.Size(248, 48);
            this.extraControls.TabIndex = 12;
            // 
            // userInput
            // 
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInput.Location = new System.Drawing.Point(624, 451);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(248, 98);
            this.userInput.TabIndex = 7;
            // 
            // pieChart
            // 
            this.pieChart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pieChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pieChart.Location = new System.Drawing.Point(12, 12);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(598, 428);
            this.pieChart.TabIndex = 6;
            // 
            // colorSelect
            // 
            this.colorSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSelect.Location = new System.Drawing.Point(12, 451);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(598, 98);
            this.colorSelect.TabIndex = 5;
            // 
            // legend
            // 
            this.legend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legend.Location = new System.Drawing.Point(624, 12);
            this.legend.Name = "legend";
            this.legend.Size = new System.Drawing.Size(248, 370);
            this.legend.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.legend);
            this.Controls.Add(this.extraControls);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.colorSelect);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.Text = "Pie Chart";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ColorSelect colorSelect;
        private UserInput userInput;
        private PieChart pieChart;
        private ExtraControls extraControls;
        private Legend legend;
    }
}

