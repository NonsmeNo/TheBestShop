namespace TheBestShop
{
    partial class FormInvoicesChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.dtpInv = new System.Windows.Forms.DateTimePicker();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.tbPaid = new System.Windows.Forms.TextBox();
            this.nudQuan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Товар";
            // 
            // cbProd
            // 
            this.cbProd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%"});
            this.cbProd.Location = new System.Drawing.Point(22, 155);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(202, 21);
            this.cbProd.TabIndex = 54;
            // 
            // dtpInv
            // 
            this.dtpInv.Location = new System.Drawing.Point(24, 66);
            this.dtpInv.Name = "dtpInv";
            this.dtpInv.Size = new System.Drawing.Size(200, 20);
            this.dtpInv.TabIndex = 53;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(149, 297);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 26);
            this.btnChange.TabIndex = 52;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(26, 297);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Дата выписки счета-фактуры";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(96, 24);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(15, 13);
            this.labelid.TabIndex = 61;
            this.labelid.Text = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Счет-фактура:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Покупатель";
            // 
            // cbCustomer
            // 
            this.cbCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%"});
            this.cbCustomer.Location = new System.Drawing.Point(22, 115);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(202, 21);
            this.cbCustomer.TabIndex = 62;
            // 
            // tbPaid
            // 
            this.tbPaid.Location = new System.Drawing.Point(22, 257);
            this.tbPaid.Name = "tbPaid";
            this.tbPaid.Size = new System.Drawing.Size(120, 20);
            this.tbPaid.TabIndex = 67;
            // 
            // nudQuan
            // 
            this.nudQuan.Location = new System.Drawing.Point(24, 201);
            this.nudQuan.Name = "nudQuan";
            this.nudQuan.Size = new System.Drawing.Size(120, 20);
            this.nudQuan.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Оплаченная сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Количество товара";
            // 
            // FormInvoicesChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 352);
            this.Controls.Add(this.tbPaid);
            this.Controls.Add(this.nudQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.dtpInv);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Name = "FormInvoicesChange";
            this.Text = "FormInvoicesChange";
            this.Load += new System.EventHandler(this.FormInvoicesChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.DateTimePicker dtpInv;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox tbPaid;
        private System.Windows.Forms.NumericUpDown nudQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}