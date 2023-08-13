namespace Assignment2
{
    partial class UserInput
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.lblValueInput = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtBoxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(75, 8);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(160, 20);
            this.txtBoxName.TabIndex = 0;
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameInput.Location = new System.Drawing.Point(14, 8);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(55, 20);
            this.lblNameInput.TabIndex = 1;
            this.lblNameInput.Text = "Name:";
            // 
            // lblValueInput
            // 
            this.lblValueInput.AutoSize = true;
            this.lblValueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueInput.Location = new System.Drawing.Point(14, 38);
            this.lblValueInput.Name = "lblValueInput";
            this.lblValueInput.Size = new System.Drawing.Size(54, 20);
            this.lblValueInput.TabIndex = 4;
            this.lblValueInput.Text = "Value:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(87, 67);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtBoxValue
            // 
            this.txtBoxValue.Location = new System.Drawing.Point(75, 38);
            this.txtBoxValue.Name = "txtBoxValue";
            this.txtBoxValue.ShortcutsEnabled = false;
            this.txtBoxValue.Size = new System.Drawing.Size(160, 20);
            this.txtBoxValue.TabIndex = 1;
            this.txtBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxValue_KeyPress);
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtBoxValue);
            this.Controls.Add(this.lblValueInput);
            this.Controls.Add(this.lblNameInput);
            this.Controls.Add(this.txtBoxName);
            this.Name = "UserInput";
            this.Size = new System.Drawing.Size(248, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.Label lblValueInput;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtBoxValue;
    }
}
