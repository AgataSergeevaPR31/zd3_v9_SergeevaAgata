namespace z3_v9_SergeevaAgata
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvShowStores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtSalesCount = new System.Windows.Forms.TextBox();
            this.txtMonthlyRevenue = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtRatingStore = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtIsOnline = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.lstHistory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStores)).BeginInit();
            this.pnlAdd.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvShowStores
            // 
            this.dgvShowStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowStores.Location = new System.Drawing.Point(13, 13);
            this.dgvShowStores.Name = "dgvShowStores";
            this.dgvShowStores.RowHeadersWidth = 51;
            this.dgvShowStores.RowTemplate.Height = 24;
            this.dgvShowStores.Size = new System.Drawing.Size(1525, 283);
            this.dgvShowStores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавить магазин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название магазина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Директор:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество продаж:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Выручка за октябрь:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Количество покупателей:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Рейтинг:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Адрес:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Онлайн:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(153, 60);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(135, 22);
            this.txtTitle.TabIndex = 12;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(84, 87);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(204, 22);
            this.txtDirector.TabIndex = 13;
            // 
            // txtSalesCount
            // 
            this.txtSalesCount.Location = new System.Drawing.Point(153, 115);
            this.txtSalesCount.Name = "txtSalesCount";
            this.txtSalesCount.Size = new System.Drawing.Size(135, 22);
            this.txtSalesCount.TabIndex = 14;
            // 
            // txtMonthlyRevenue
            // 
            this.txtMonthlyRevenue.Location = new System.Drawing.Point(153, 149);
            this.txtMonthlyRevenue.Name = "txtMonthlyRevenue";
            this.txtMonthlyRevenue.Size = new System.Drawing.Size(135, 22);
            this.txtMonthlyRevenue.TabIndex = 15;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(188, 177);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 22);
            this.txtP.TabIndex = 16;
            // 
            // txtRatingStore
            // 
            this.txtRatingStore.Location = new System.Drawing.Point(75, 206);
            this.txtRatingStore.Name = "txtRatingStore";
            this.txtRatingStore.Size = new System.Drawing.Size(213, 22);
            this.txtRatingStore.TabIndex = 17;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(60, 234);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(228, 22);
            this.txtLocation.TabIndex = 18;
            // 
            // txtIsOnline
            // 
            this.txtIsOnline.Location = new System.Drawing.Point(71, 261);
            this.txtIsOnline.Name = "txtIsOnline";
            this.txtIsOnline.Size = new System.Drawing.Size(217, 22);
            this.txtIsOnline.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(96, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(146, 20);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Удалить по имени";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(237, 20);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Удалить по количеству продаж ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(29, 77);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(222, 20);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Удалить по выручке за месяц";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(29, 114);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(237, 22);
            this.txtDelete.TabIndex = 24;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.txtIsOnline);
            this.pnlAdd.Controls.Add(this.txtLocation);
            this.pnlAdd.Controls.Add(this.txtRatingStore);
            this.pnlAdd.Controls.Add(this.txtP);
            this.pnlAdd.Controls.Add(this.txtMonthlyRevenue);
            this.pnlAdd.Controls.Add(this.txtSalesCount);
            this.pnlAdd.Controls.Add(this.txtDirector);
            this.pnlAdd.Controls.Add(this.txtTitle);
            this.pnlAdd.Controls.Add(this.label9);
            this.pnlAdd.Controls.Add(this.label8);
            this.pnlAdd.Controls.Add(this.label7);
            this.pnlAdd.Controls.Add(this.label6);
            this.pnlAdd.Controls.Add(this.label5);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Location = new System.Drawing.Point(13, 315);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(319, 335);
            this.pnlAdd.TabIndex = 25;
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.txtDelete);
            this.pnlDelete.Controls.Add(this.radioButton3);
            this.pnlDelete.Controls.Add(this.radioButton2);
            this.pnlDelete.Controls.Add(this.radioButton1);
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.Location = new System.Drawing.Point(340, 315);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(293, 201);
            this.pnlDelete.TabIndex = 26;
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 16;
            this.lstHistory.Location = new System.Drawing.Point(340, 523);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(448, 116);
            this.lstHistory.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 651);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.dgvShowStores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStores)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvShowStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtSalesCount;
        private System.Windows.Forms.TextBox txtMonthlyRevenue;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtRatingStore;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtIsOnline;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.ListBox lstHistory;
    }
}

