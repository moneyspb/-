namespace TapTaxi
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьСтатусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.забралПассажираToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поездкаЗавершенаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поездкаОтмененаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пассажирНеОтвечаетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.taxistDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.fromPlaceDataGridViewTextBoxColumn,
            this.toPlaceDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(968, 440);
            this.dataGridView1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.сменитьСтатусToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сменитьСтатусToolStripMenuItem
            // 
            this.сменитьСтатусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.забралПассажираToolStripMenuItem,
            this.поездкаЗавершенаToolStripMenuItem,
            this.поездкаОтмененаToolStripMenuItem,
            this.пассажирНеОтвечаетToolStripMenuItem});
            this.сменитьСтатусToolStripMenuItem.Name = "сменитьСтатусToolStripMenuItem";
            this.сменитьСтатусToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.сменитьСтатусToolStripMenuItem.Text = "Сменить статус";
            // 
            // забралПассажираToolStripMenuItem
            // 
            this.забралПассажираToolStripMenuItem.Name = "забралПассажираToolStripMenuItem";
            this.забралПассажираToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.забралПассажираToolStripMenuItem.Text = "Забрал пассажира";
            this.забралПассажираToolStripMenuItem.Click += new System.EventHandler(this.забралПассажираToolStripMenuItem_Click);
            // 
            // поездкаЗавершенаToolStripMenuItem
            // 
            this.поездкаЗавершенаToolStripMenuItem.Name = "поездкаЗавершенаToolStripMenuItem";
            this.поездкаЗавершенаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.поездкаЗавершенаToolStripMenuItem.Text = "Поездка завершена";
            this.поездкаЗавершенаToolStripMenuItem.Click += new System.EventHandler(this.поездкаЗавершенаToolStripMenuItem_Click);
            // 
            // поездкаОтмененаToolStripMenuItem
            // 
            this.поездкаОтмененаToolStripMenuItem.Name = "поездкаОтмененаToolStripMenuItem";
            this.поездкаОтмененаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.поездкаОтмененаToolStripMenuItem.Text = "Поездка отменена";
            this.поездкаОтмененаToolStripMenuItem.Click += new System.EventHandler(this.поездкаОтмененаToolStripMenuItem_Click);
            // 
            // пассажирНеОтвечаетToolStripMenuItem
            // 
            this.пассажирНеОтвечаетToolStripMenuItem.Name = "пассажирНеОтвечаетToolStripMenuItem";
            this.пассажирНеОтвечаетToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.пассажирНеОтвечаетToolStripMenuItem.Text = "Пассажир не отвечает";
            this.пассажирНеОтвечаетToolStripMenuItem.Click += new System.EventHandler(this.пассажирНеОтвечаетToolStripMenuItem_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxistDataGridViewTextBoxColumn
            // 
            this.taxistDataGridViewTextBoxColumn.DataPropertyName = "Taxist";
            this.taxistDataGridViewTextBoxColumn.HeaderText = "Водитель";
            this.taxistDataGridViewTextBoxColumn.Name = "taxistDataGridViewTextBoxColumn";
            this.taxistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromPlaceDataGridViewTextBoxColumn
            // 
            this.fromPlaceDataGridViewTextBoxColumn.DataPropertyName = "FromPlace";
            this.fromPlaceDataGridViewTextBoxColumn.HeaderText = "Откуда";
            this.fromPlaceDataGridViewTextBoxColumn.Name = "fromPlaceDataGridViewTextBoxColumn";
            this.fromPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toPlaceDataGridViewTextBoxColumn
            // 
            this.toPlaceDataGridViewTextBoxColumn.DataPropertyName = "ToPlace";
            this.toPlaceDataGridViewTextBoxColumn.HeaderText = "Куда";
            this.toPlaceDataGridViewTextBoxColumn.Name = "toPlaceDataGridViewTextBoxColumn";
            this.toPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(TapTaxi.Core.Order);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Новые",
            "В процессе",
            "Завершенные",
            "Отмененные"});
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 521);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.ToolStripMenuItem сменитьСтатусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem забралПассажираToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поездкаЗавершенаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поездкаОтмененаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пассажирНеОтвечаетToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}