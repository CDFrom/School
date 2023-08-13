namespace Assignment2
{
    partial class Legend
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLegend = new System.Windows.Forms.GroupBox();
            this.listBoxLegend = new System.Windows.Forms.ListBox();
            this.groupBoxLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLegend
            // 
            this.groupBoxLegend.Controls.Add(this.listBoxLegend);
            this.groupBoxLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLegend.Location = new System.Drawing.Point(3, -1);
            this.groupBoxLegend.Name = "groupBoxLegend";
            this.groupBoxLegend.Size = new System.Drawing.Size(242, 368);
            this.groupBoxLegend.TabIndex = 0;
            this.groupBoxLegend.TabStop = false;
            this.groupBoxLegend.Text = "Legend";
            // 
            // listBoxLegend
            // 
            this.listBoxLegend.FormattingEnabled = true;
            this.listBoxLegend.HorizontalScrollbar = true;
            this.listBoxLegend.ItemHeight = 20;
            this.listBoxLegend.Items.AddRange(new object[] {
            "Can hold up to 15 items..."});
            this.listBoxLegend.Location = new System.Drawing.Point(6, 25);
            this.listBoxLegend.Name = "listBoxLegend";
            this.listBoxLegend.Size = new System.Drawing.Size(230, 324);
            this.listBoxLegend.TabIndex = 0;
            this.listBoxLegend.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxLegend_DrawItem);
            // 
            // Legend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBoxLegend);
            this.Name = "Legend";
            this.Size = new System.Drawing.Size(248, 370);
            this.Load += new System.EventHandler(this.Legend_Load);
            this.groupBoxLegend.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLegend;
        private System.Windows.Forms.ListBox listBoxLegend;
    }
}
