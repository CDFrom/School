
namespace CoffeeShop
{
    partial class CoffeeSelection
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
            this.rbtnSmall = new System.Windows.Forms.RadioButton();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.rbtnLarge = new System.Windows.Forms.RadioButton();
            this.numericUpDownCream = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSugar = new System.Windows.Forms.NumericUpDown();
            this.lblCream = new System.Windows.Forms.Label();
            this.lblSugar = new System.Windows.Forms.Label();
            this.checkBoxWhippedCream = new System.Windows.Forms.CheckBox();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.groupBoxExtra = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugar)).BeginInit();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnSmall
            // 
            this.rbtnSmall.AutoSize = true;
            this.rbtnSmall.Location = new System.Drawing.Point(6, 45);
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.Size = new System.Drawing.Size(125, 52);
            this.rbtnSmall.TabIndex = 0;
            this.rbtnSmall.Text = "Small";
            this.rbtnSmall.UseVisualStyleBackColor = true;
            this.rbtnSmall.CheckedChanged += new System.EventHandler(this.rbtnSmall_CheckedChanged);
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Location = new System.Drawing.Point(6, 85);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(159, 52);
            this.rbtnMedium.TabIndex = 1;
            this.rbtnMedium.Text = "Medium";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            this.rbtnMedium.CheckedChanged += new System.EventHandler(this.rbtnMedium_CheckedChanged);
            // 
            // rbtnLarge
            // 
            this.rbtnLarge.AutoSize = true;
            this.rbtnLarge.Checked = true;
            this.rbtnLarge.Location = new System.Drawing.Point(6, 130);
            this.rbtnLarge.Name = "rbtnLarge";
            this.rbtnLarge.Size = new System.Drawing.Size(121, 52);
            this.rbtnLarge.TabIndex = 2;
            this.rbtnLarge.TabStop = true;
            this.rbtnLarge.Text = "Large";
            this.rbtnLarge.UseVisualStyleBackColor = true;
            this.rbtnLarge.CheckedChanged += new System.EventHandler(this.rbtnLarge_CheckedChanged);
            // 
            // numericUpDownCream
            // 
            this.numericUpDownCream.Location = new System.Drawing.Point(119, 32);
            this.numericUpDownCream.Name = "numericUpDownCream";
            this.numericUpDownCream.Size = new System.Drawing.Size(147, 54);
            this.numericUpDownCream.TabIndex = 3;
            // 
            // numericUpDownSugar
            // 
            this.numericUpDownSugar.Location = new System.Drawing.Point(119, 93);
            this.numericUpDownSugar.Name = "numericUpDownSugar";
            this.numericUpDownSugar.Size = new System.Drawing.Size(147, 54);
            this.numericUpDownSugar.TabIndex = 4;
            // 
            // lblCream
            // 
            this.lblCream.AutoSize = true;
            this.lblCream.Location = new System.Drawing.Point(6, 34);
            this.lblCream.Name = "lblCream";
            this.lblCream.Size = new System.Drawing.Size(107, 48);
            this.lblCream.TabIndex = 5;
            this.lblCream.Text = "Cream";
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Location = new System.Drawing.Point(6, 95);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(107, 48);
            this.lblSugar.TabIndex = 6;
            this.lblSugar.Text = "Sugar";
            // 
            // checkBoxWhippedCream
            // 
            this.checkBoxWhippedCream.AutoSize = true;
            this.checkBoxWhippedCream.Location = new System.Drawing.Point(6, 143);
            this.checkBoxWhippedCream.Name = "checkBoxWhippedCream";
            this.checkBoxWhippedCream.Size = new System.Drawing.Size(260, 52);
            this.checkBoxWhippedCream.TabIndex = 7;
            this.checkBoxWhippedCream.Text = "Whipped Cream";
            this.checkBoxWhippedCream.UseVisualStyleBackColor = true;
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(208, 17);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(95, 48);
            this.lblCoffee.TabIndex = 8;
            this.lblCoffee.Text = "Coffee";
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.rbtnSmall);
            this.groupBoxSize.Controls.Add(this.rbtnMedium);
            this.groupBoxSize.Controls.Add(this.rbtnLarge);
            this.groupBoxSize.Location = new System.Drawing.Point(3, 101);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(182, 191);
            this.groupBoxSize.TabIndex = 9;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // groupBoxExtra
            // 
            this.groupBoxExtra.Controls.Add(this.lblCream);
            this.groupBoxExtra.Controls.Add(this.numericUpDownCream);
            this.groupBoxExtra.Controls.Add(this.numericUpDownSugar);
            this.groupBoxExtra.Controls.Add(this.checkBoxWhippedCream);
            this.groupBoxExtra.Controls.Add(this.lblSugar);
            this.groupBoxExtra.Location = new System.Drawing.Point(191, 91);
            this.groupBoxExtra.Name = "groupBoxExtra";
            this.groupBoxExtra.Size = new System.Drawing.Size(315, 201);
            this.groupBoxExtra.TabIndex = 10;
            this.groupBoxExtra.TabStop = false;
            this.groupBoxExtra.Text = "Extra";
            // 
            // CoffeeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBoxExtra);
            this.Controls.Add(this.lblCoffee);
            this.Font = new System.Drawing.Font("Rage Italic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "CoffeeSelection";
            this.Size = new System.Drawing.Size(510, 300);
            this.Load += new System.EventHandler(this.CoffeeSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugar)).EndInit();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxExtra.ResumeLayout(false);
            this.groupBoxExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnSmall;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.RadioButton rbtnLarge;
        private System.Windows.Forms.NumericUpDown numericUpDownCream;
        private System.Windows.Forms.NumericUpDown numericUpDownSugar;
        private System.Windows.Forms.Label lblCream;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.CheckBox checkBoxWhippedCream;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.GroupBox groupBoxExtra;
    }
}
