namespace TheBestShop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.buttonDel1 = new System.Windows.Forms.Button();
            this.buttonChange1 = new System.Windows.Forms.Button();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Products = new System.Windows.Forms.TabPage();
            this.buttonDel2 = new System.Windows.Forms.Button();
            this.buttonChange2 = new System.Windows.Forms.Button();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Invoices1 = new System.Windows.Forms.TabPage();
            this.buttonDel3 = new System.Windows.Forms.Button();
            this.buttonChange3 = new System.Windows.Forms.Button();
            this.buttonAdd3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Report = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReport2 = new System.Windows.Forms.Button();
            this.dtpCur = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReport1 = new System.Windows.Forms.Button();
            this.Invoices = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Invoices1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.Products);
            this.tabControl1.Controls.Add(this.Invoices1);
            this.tabControl1.Controls.Add(this.Report);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.Honeydew;
            this.Customers.Controls.Add(this.buttonDel1);
            this.Customers.Controls.Add(this.buttonChange1);
            this.Customers.Controls.Add(this.buttonAdd1);
            this.Customers.Controls.Add(this.dataGridView1);
            this.Customers.Location = new System.Drawing.Point(4, 34);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(717, 381);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Покупатели";
            // 
            // buttonDel1
            // 
            this.buttonDel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDel1.Location = new System.Drawing.Point(336, 336);
            this.buttonDel1.Name = "buttonDel1";
            this.buttonDel1.Size = new System.Drawing.Size(159, 42);
            this.buttonDel1.TabIndex = 3;
            this.buttonDel1.Text = "УДАЛИТЬ";
            this.buttonDel1.UseVisualStyleBackColor = false;
            this.buttonDel1.Click += new System.EventHandler(this.buttonDel1_Click);
            // 
            // buttonChange1
            // 
            this.buttonChange1.BackColor = System.Drawing.Color.Gold;
            this.buttonChange1.Location = new System.Drawing.Point(171, 336);
            this.buttonChange1.Name = "buttonChange1";
            this.buttonChange1.Size = new System.Drawing.Size(159, 42);
            this.buttonChange1.TabIndex = 2;
            this.buttonChange1.Text = "ИЗМЕНИТЬ";
            this.buttonChange1.UseVisualStyleBackColor = false;
            this.buttonChange1.Click += new System.EventHandler(this.buttonChange1_Click);
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd1.Location = new System.Drawing.Point(6, 336);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(159, 42);
            this.buttonAdd1.TabIndex = 1;
            this.buttonAdd1.Text = "ДОБАВИТЬ";
            this.buttonAdd1.UseVisualStyleBackColor = false;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Honeydew;
            this.Products.Controls.Add(this.buttonDel2);
            this.Products.Controls.Add(this.buttonChange2);
            this.Products.Controls.Add(this.buttonAdd2);
            this.Products.Controls.Add(this.dataGridView2);
            this.Products.Location = new System.Drawing.Point(4, 34);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(717, 381);
            this.Products.TabIndex = 1;
            this.Products.Text = "Товары";
            // 
            // buttonDel2
            // 
            this.buttonDel2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDel2.Location = new System.Drawing.Point(336, 336);
            this.buttonDel2.Name = "buttonDel2";
            this.buttonDel2.Size = new System.Drawing.Size(159, 42);
            this.buttonDel2.TabIndex = 7;
            this.buttonDel2.Text = "УДАЛИТЬ";
            this.buttonDel2.UseVisualStyleBackColor = false;
            this.buttonDel2.Click += new System.EventHandler(this.buttonDel2_Click);
            // 
            // buttonChange2
            // 
            this.buttonChange2.BackColor = System.Drawing.Color.Gold;
            this.buttonChange2.Location = new System.Drawing.Point(171, 336);
            this.buttonChange2.Name = "buttonChange2";
            this.buttonChange2.Size = new System.Drawing.Size(159, 42);
            this.buttonChange2.TabIndex = 6;
            this.buttonChange2.Text = "ИЗМЕНИТЬ";
            this.buttonChange2.UseVisualStyleBackColor = false;
            this.buttonChange2.Click += new System.EventHandler(this.buttonСhange2_Click);
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd2.Location = new System.Drawing.Point(6, 336);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(159, 42);
            this.buttonAdd2.TabIndex = 5;
            this.buttonAdd2.Text = "ДОБАВИТЬ";
            this.buttonAdd2.UseVisualStyleBackColor = false;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(705, 324);
            this.dataGridView2.TabIndex = 4;
            // 
            // Invoices1
            // 
            this.Invoices1.BackColor = System.Drawing.Color.Honeydew;
            this.Invoices1.Controls.Add(this.buttonDel3);
            this.Invoices1.Controls.Add(this.buttonChange3);
            this.Invoices1.Controls.Add(this.buttonAdd3);
            this.Invoices1.Controls.Add(this.dataGridView3);
            this.Invoices1.Location = new System.Drawing.Point(4, 34);
            this.Invoices1.Name = "Invoices1";
            this.Invoices1.Size = new System.Drawing.Size(717, 381);
            this.Invoices1.TabIndex = 2;
            this.Invoices1.Text = "Счета-фактуры";
            // 
            // buttonDel3
            // 
            this.buttonDel3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDel3.Location = new System.Drawing.Point(336, 336);
            this.buttonDel3.Name = "buttonDel3";
            this.buttonDel3.Size = new System.Drawing.Size(159, 42);
            this.buttonDel3.TabIndex = 11;
            this.buttonDel3.Text = "УДАЛИТЬ";
            this.buttonDel3.UseVisualStyleBackColor = false;
            this.buttonDel3.Click += new System.EventHandler(this.buttonDel3_Click);
            // 
            // buttonChange3
            // 
            this.buttonChange3.BackColor = System.Drawing.Color.Gold;
            this.buttonChange3.Location = new System.Drawing.Point(171, 336);
            this.buttonChange3.Name = "buttonChange3";
            this.buttonChange3.Size = new System.Drawing.Size(159, 42);
            this.buttonChange3.TabIndex = 10;
            this.buttonChange3.Text = "ИЗМЕНИТЬ";
            this.buttonChange3.UseVisualStyleBackColor = false;
            this.buttonChange3.Click += new System.EventHandler(this.buttonChange3_Click);
            // 
            // buttonAdd3
            // 
            this.buttonAdd3.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd3.Location = new System.Drawing.Point(6, 336);
            this.buttonAdd3.Name = "buttonAdd3";
            this.buttonAdd3.Size = new System.Drawing.Size(159, 42);
            this.buttonAdd3.TabIndex = 9;
            this.buttonAdd3.Text = "ДОБАВИТЬ";
            this.buttonAdd3.UseVisualStyleBackColor = false;
            this.buttonAdd3.Click += new System.EventHandler(this.buttonAdd3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(708, 327);
            this.dataGridView3.TabIndex = 8;
            // 
            // Report
            // 
            this.Report.Controls.Add(this.chart2);
            this.Report.Controls.Add(this.chart1);
            this.Report.Controls.Add(this.dateEnd);
            this.Report.Controls.Add(this.dateStart);
            this.Report.Controls.Add(this.label6);
            this.Report.Controls.Add(this.label7);
            this.Report.Controls.Add(this.label5);
            this.Report.Controls.Add(this.label2);
            this.Report.Controls.Add(this.label4);
            this.Report.Controls.Add(this.label3);
            this.Report.Controls.Add(this.buttonReport2);
            this.Report.Controls.Add(this.dtpCur);
            this.Report.Controls.Add(this.label1);
            this.Report.Controls.Add(this.buttonReport1);
            this.Report.Location = new System.Drawing.Point(4, 34);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(717, 381);
            this.Report.TabIndex = 3;
            this.Report.Text = "Отчет";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(380, 164);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(240, 184);
            this.chart2.TabIndex = 23;
            this.chart2.Text = "chart2";
            title3.Name = "Title1";
            title3.Text = "Соотношение сумм проданных товаров пропорционально их ставок НДС";
            this.chart2.Titles.Add(title3);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(34, 164);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(240, 184);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Номера счетов-фактур с просроченными платежами";
            this.chart1.Titles.Add(title4);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(380, 120);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(170, 20);
            this.dateEnd.TabIndex = 21;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(380, 73);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(170, 20);
            this.dateStart.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Конец периода";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Начало периода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(377, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "  пропорционально их ставок НДС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(377, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Соотношение сумм проданных товаров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = " по которым просрочены платежи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cписок счётов-фактур";
            // 
            // buttonReport2
            // 
            this.buttonReport2.Location = new System.Drawing.Point(579, 104);
            this.buttonReport2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReport2.Name = "buttonReport2";
            this.buttonReport2.Size = new System.Drawing.Size(100, 36);
            this.buttonReport2.TabIndex = 13;
            this.buttonReport2.Text = "Сформировать отчёт";
            this.buttonReport2.UseVisualStyleBackColor = true;
            this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // dtpCur
            // 
            this.dtpCur.Location = new System.Drawing.Point(34, 73);
            this.dtpCur.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCur.Name = "dtpCur";
            this.dtpCur.Size = new System.Drawing.Size(170, 20);
            this.dtpCur.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дата";
            // 
            // buttonReport1
            // 
            this.buttonReport1.Location = new System.Drawing.Point(34, 106);
            this.buttonReport1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReport1.Name = "buttonReport1";
            this.buttonReport1.Size = new System.Drawing.Size(100, 36);
            this.buttonReport1.TabIndex = 7;
            this.buttonReport1.Text = "Сформировать отчёт";
            this.buttonReport1.UseVisualStyleBackColor = true;
            this.buttonReport1.Click += new System.EventHandler(this.buttonReport1_Click);
            // 
            // Invoices
            // 
            this.Invoices.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Invoices.Location = new System.Drawing.Point(4, 29);
            this.Invoices.Name = "Invoices";
            this.Invoices.Size = new System.Drawing.Size(717, 386);
            this.Invoices.TabIndex = 2;
            this.Invoices.Text = "Счета-фактуры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Магазин";
            this.tabControl1.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Invoices1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Report.ResumeLayout(false);
            this.Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.Button buttonDel1;
        private System.Windows.Forms.Button buttonChange1;
        private System.Windows.Forms.Button buttonDel2;
        private System.Windows.Forms.Button buttonChange2;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage Invoices1;
        private System.Windows.Forms.TabPage Invoices;
        private System.Windows.Forms.Button buttonDel3;
        private System.Windows.Forms.Button buttonChange3;
        private System.Windows.Forms.Button buttonAdd3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage Report;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpCur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReport1;
        private System.Windows.Forms.Button buttonReport2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}

