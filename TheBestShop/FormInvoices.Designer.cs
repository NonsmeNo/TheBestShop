namespace TheBestShop
{
    partial class FormInvoices
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInv = new System.Windows.Forms.DateTimePicker();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuan = new System.Windows.Forms.NumericUpDown();
            this.tbPaid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 268);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(28, 268);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Дата выписки счета-фактуры";
            // 
            // dtpInv
            // 
            this.dtpInv.Location = new System.Drawing.Point(30, 35);
            this.dtpInv.Name = "dtpInv";
            this.dtpInv.Size = new System.Drawing.Size(200, 20);
            this.dtpInv.TabIndex = 43;
            // 
            // cbProd
            // 
            this.cbProd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%"});
            this.cbProd.Location = new System.Drawing.Point(28, 124);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(202, 21);
            this.cbProd.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Количество товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Оплаченная сумма";
            // 
            // nudQuan
            // 
            this.nudQuan.Location = new System.Drawing.Point(30, 173);
            this.nudQuan.Name = "nudQuan";
            this.nudQuan.Size = new System.Drawing.Size(120, 20);
            this.nudQuan.TabIndex = 50;
            // 
            // tbPaid
            // 
            this.tbPaid.Location = new System.Drawing.Point(28, 234);
            this.tbPaid.Name = "tbPaid";
            this.tbPaid.Size = new System.Drawing.Size(120, 20);
            this.tbPaid.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Покупатель";
            // 
            // cbCustomer
            // 
            this.cbCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%"});
            this.cbCustomer.Location = new System.Drawing.Point(28, 78);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(202, 21);
            this.cbCustomer.TabIndex = 52;
            // 
            // FormInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 332);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.tbPaid);
            this.Controls.Add(this.nudQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.dtpInv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Name = "FormInvoices";
            this.Text = "Добавление счета-фактуры";
            this.Load += new System.EventHandler(this.FormInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInv;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuan;
        private System.Windows.Forms.TextBox tbPaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCustomer;
    }
}