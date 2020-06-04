namespace TapTaxi
{
    partial class NewOrderForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDriver = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcCost = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxTariff = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(396, 422);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(133, 43);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(537, 422);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 43);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Водитель";
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.FormattingEnabled = true;
            this.comboBoxDriver.Location = new System.Drawing.Point(212, 77);
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(458, 28);
            this.comboBoxDriver.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "Дата: dd MMM yyyy; Время: HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(458, 26);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Дата";
            // 
            // txtBxFrom
            // 
            this.txtBxFrom.Location = new System.Drawing.Point(212, 158);
            this.txtBxFrom.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBxFrom.Name = "txtBxFrom";
            this.txtBxFrom.Size = new System.Drawing.Size(458, 26);
            this.txtBxFrom.TabIndex = 37;
            this.txtBxFrom.TextChanged += new System.EventHandler(this.txtBxFrom_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Откуда";
            // 
            // txtBxTo
            // 
            this.txtBxTo.Location = new System.Drawing.Point(212, 200);
            this.txtBxTo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBxTo.Name = "txtBxTo";
            this.txtBxTo.Size = new System.Drawing.Size(458, 26);
            this.txtBxTo.TabIndex = 39;
            this.txtBxTo.TextChanged += new System.EventHandler(this.txtBxFrom_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Куда";
            // 
            // txtBxCost
            // 
            this.txtBxCost.Location = new System.Drawing.Point(212, 242);
            this.txtBxCost.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBxCost.Name = "txtBxCost";
            this.txtBxCost.ReadOnly = true;
            this.txtBxCost.Size = new System.Drawing.Size(458, 26);
            this.txtBxCost.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Стоимость";
            // 
            // btnCalcCost
            // 
            this.btnCalcCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCalcCost.Location = new System.Drawing.Point(575, 348);
            this.btnCalcCost.Name = "btnCalcCost";
            this.btnCalcCost.Size = new System.Drawing.Size(95, 43);
            this.btnCalcCost.TabIndex = 42;
            this.btnCalcCost.Text = "Расчет стоимости";
            this.btnCalcCost.UseVisualStyleBackColor = true;
            this.btnCalcCost.Click += new System.EventHandler(this.btnCalcCost_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(212, 35);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(458, 26);
            this.maskedTextBox1.TabIndex = 43;
            // 
            // comboBoxTariff
            // 
            this.comboBoxTariff.FormattingEnabled = true;
            this.comboBoxTariff.Items.AddRange(new object[] {
            "Эконом",
            "Комфорт",
            "Бизнес"});
            this.comboBoxTariff.Location = new System.Drawing.Point(212, 279);
            this.comboBoxTariff.Name = "comboBoxTariff";
            this.comboBoxTariff.Size = new System.Drawing.Size(458, 28);
            this.comboBoxTariff.TabIndex = 45;
            this.comboBoxTariff.SelectedIndexChanged += new System.EventHandler(this.comboBoxTariff_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Тариф";
            // 
            // NewOrderForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.comboBoxTariff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnCalcCost);
            this.Controls.Add(this.txtBxCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxDriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказать такси";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDriver;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcCost;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBoxTariff;
        private System.Windows.Forms.Label label7;
    }
}