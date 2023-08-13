
namespace CoffeeShop
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
            this.btnDonut = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.containerShop = new CoffeeShop.Container();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDonut
            // 
            this.btnDonut.Location = new System.Drawing.Point(12, 87);
            this.btnDonut.Name = "btnDonut";
            this.btnDonut.Size = new System.Drawing.Size(155, 69);
            this.btnDonut.TabIndex = 0;
            this.btnDonut.Text = "Donut";
            this.btnDonut.UseVisualStyleBackColor = true;
            this.btnDonut.Click += new System.EventHandler(this.btnDonut_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.Location = new System.Drawing.Point(12, 12);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(155, 69);
            this.btnCoffee.TabIndex = 1;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 443);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 69);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(719, 129);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(379, 383);
            this.txtOrder.TabIndex = 4;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlLine.Location = new System.Drawing.Point(719, 113);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(379, 15);
            this.pnlLine.TabIndex = 5;
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.pBoxLogo);
            this.pnlPicture.Location = new System.Drawing.Point(719, 12);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(379, 100);
            this.pnlPicture.TabIndex = 6;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Location = new System.Drawing.Point(123, 0);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(151, 100);
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            // 
            // containerShop
            // 
            this.containerShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerShop.Location = new System.Drawing.Point(178, 12);
            this.containerShop.Margin = new System.Windows.Forms.Padding(8);
            this.containerShop.Name = "containerShop";
            this.containerShop.Size = new System.Drawing.Size(530, 500);
            this.containerShop.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 368);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(155, 69);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 534);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.pnlPicture);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.containerShop);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.btnDonut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximumSize = new System.Drawing.Size(1160, 581);
            this.MinimumSize = new System.Drawing.Size(1160, 581);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDonut;
        private System.Windows.Forms.Button btnCoffee;
        private Container containerShop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Button btnOrder;
    }
}

