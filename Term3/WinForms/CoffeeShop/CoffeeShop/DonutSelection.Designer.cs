
namespace CoffeeShop
{
    partial class DonutSelection
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
            this.numericUpDownDonut = new System.Windows.Forms.NumericUpDown();
            this.lblDonut = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonut)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownDonut
            // 
            this.numericUpDownDonut.Location = new System.Drawing.Point(161, 58);
            this.numericUpDownDonut.Name = "numericUpDownDonut";
            this.numericUpDownDonut.Size = new System.Drawing.Size(120, 48);
            this.numericUpDownDonut.TabIndex = 0;
            this.numericUpDownDonut.ValueChanged += new System.EventHandler(this.numericUpDownDonut_ValueChanged);
            // 
            // lblDonut
            // 
            this.lblDonut.AutoSize = true;
            this.lblDonut.Location = new System.Drawing.Point(92, 10);
            this.lblDonut.Name = "lblDonut";
            this.lblDonut.Size = new System.Drawing.Size(104, 45);
            this.lblDonut.TabIndex = 1;
            this.lblDonut.Text = "Donut";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(11, 60);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(144, 45);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // DonutSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDonut);
            this.Controls.Add(this.numericUpDownDonut);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "DonutSelection";
            this.Size = new System.Drawing.Size(300, 130);
            this.Load += new System.EventHandler(this.DonutSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownDonut;
        private System.Windows.Forms.Label lblDonut;
        private System.Windows.Forms.Label lblQuantity;
    }
}
