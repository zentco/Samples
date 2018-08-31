namespace InvoiceTotal
{
    partial class frmInvoiceControl
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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.textSubtotal = new System.Windows.Forms.TextBox();
            this.textDiscountPercent = new System.Windows.Forms.TextBox();
            this.lblDiscountPerc = new System.Windows.Forms.Label();
            this.textDiscountAmt = new System.Windows.Forms.TextBox();
            this.lblDiscountAmt = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(64, 32);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "&Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSubtotal
            // 
            this.textSubtotal.Location = new System.Drawing.Point(180, 32);
            this.textSubtotal.Name = "textSubtotal";
            this.textSubtotal.Size = new System.Drawing.Size(146, 20);
            this.textSubtotal.TabIndex = 1;
            this.textSubtotal.TabStop = false;
            this.textSubtotal.TextChanged += new System.EventHandler(this.textSubtotal_TextChanged);
            // 
            // textDiscountPercent
            // 
            this.textDiscountPercent.Location = new System.Drawing.Point(180, 67);
            this.textDiscountPercent.Name = "textDiscountPercent";
            this.textDiscountPercent.ReadOnly = true;
            this.textDiscountPercent.Size = new System.Drawing.Size(146, 20);
            this.textDiscountPercent.TabIndex = 0;
            // 
            // lblDiscountPerc
            // 
            this.lblDiscountPerc.AutoSize = true;
            this.lblDiscountPerc.Location = new System.Drawing.Point(64, 67);
            this.lblDiscountPerc.Name = "lblDiscountPerc";
            this.lblDiscountPerc.Size = new System.Drawing.Size(92, 13);
            this.lblDiscountPerc.TabIndex = 2;
            this.lblDiscountPerc.Text = "Discount Percent:";
            this.lblDiscountPerc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textDiscountAmt
            // 
            this.textDiscountAmt.Location = new System.Drawing.Point(180, 104);
            this.textDiscountAmt.Name = "textDiscountAmt";
            this.textDiscountAmt.ReadOnly = true;
            this.textDiscountAmt.Size = new System.Drawing.Size(146, 20);
            this.textDiscountAmt.TabIndex = 0;
            // 
            // lblDiscountAmt
            // 
            this.lblDiscountAmt.AutoSize = true;
            this.lblDiscountAmt.Location = new System.Drawing.Point(64, 104);
            this.lblDiscountAmt.Name = "lblDiscountAmt";
            this.lblDiscountAmt.Size = new System.Drawing.Size(91, 13);
            this.lblDiscountAmt.TabIndex = 4;
            this.lblDiscountAmt.Text = "Discount Amount:";
            this.lblDiscountAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(180, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(64, 143);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(60, 199);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(219, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmInvoiceControl
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(405, 256);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.textDiscountAmt);
            this.Controls.Add(this.lblDiscountAmt);
            this.Controls.Add(this.textDiscountPercent);
            this.Controls.Add(this.lblDiscountPerc);
            this.Controls.Add(this.textSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Name = "frmInvoiceControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceTotal";
            this.Load += new System.EventHandler(this.frmInvoiceControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox textSubtotal;
        private System.Windows.Forms.TextBox textDiscountPercent;
        private System.Windows.Forms.Label lblDiscountPerc;
        private System.Windows.Forms.TextBox textDiscountAmt;
        private System.Windows.Forms.Label lblDiscountAmt;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

