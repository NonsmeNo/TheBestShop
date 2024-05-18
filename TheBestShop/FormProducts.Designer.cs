namespace TheBestShop
{
    partial class FormProducts
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
            this.tbnameProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNDS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(158, 208);
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
            this.btnClose.Location = new System.Drawing.Point(24, 208);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbnameProd
            // 
            this.tbnameProd.Location = new System.Drawing.Point(25, 51);
            this.tbnameProd.Margin = new System.Windows.Forms.Padding(2);
            this.tbnameProd.Name = "tbnameProd";
            this.tbnameProd.Size = new System.Drawing.Size(208, 20);
            this.tbnameProd.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Название товара";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(25, 96);
            this.tbCost.Margin = new System.Windows.Forms.Padding(2);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(208, 20);
            this.tbCost.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Стоимость";
            // 
            // cbNDS
            // 
            this.cbNDS.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbNDS.FormattingEnabled = true;
            this.cbNDS.Items.AddRange(new object[] {
            "10%",
            "15%",
            "20%"});
            this.cbNDS.Location = new System.Drawing.Point(24, 143);
            this.cbNDS.Name = "cbNDS";
            this.cbNDS.Size = new System.Drawing.Size(209, 21);
            this.cbNDS.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "НДС";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNDS);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbnameProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label1);
            this.Name = "FormProducts";
            this.Text = "Добавление товара";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbnameProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNDS;
        private System.Windows.Forms.Label label2;
    }
}