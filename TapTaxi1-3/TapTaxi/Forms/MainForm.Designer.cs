namespace TapTaxi
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
            this.btnTaxist = new System.Windows.Forms.Button();
            this.btnPassengers = new System.Windows.Forms.Button();
            this.btnModels = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnManagers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaxist
            // 
            this.btnTaxist.Location = new System.Drawing.Point(136, 23);
            this.btnTaxist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaxist.Name = "btnTaxist";
            this.btnTaxist.Size = new System.Drawing.Size(166, 63);
            this.btnTaxist.TabIndex = 0;
            this.btnTaxist.Text = "Таксисты";
            this.btnTaxist.UseVisualStyleBackColor = true;
            this.btnTaxist.Click += new System.EventHandler(this.btnTaxist_Click);
            // 
            // btnPassengers
            // 
            this.btnPassengers.Location = new System.Drawing.Point(136, 94);
            this.btnPassengers.Name = "btnPassengers";
            this.btnPassengers.Size = new System.Drawing.Size(166, 56);
            this.btnPassengers.TabIndex = 1;
            this.btnPassengers.Text = "Пассажиры";
            this.btnPassengers.UseVisualStyleBackColor = true;
            this.btnPassengers.Click += new System.EventHandler(this.btnPassengers_Click);
            // 
            // btnModels
            // 
            this.btnModels.Location = new System.Drawing.Point(136, 225);
            this.btnModels.Name = "btnModels";
            this.btnModels.Size = new System.Drawing.Size(166, 56);
            this.btnModels.TabIndex = 2;
            this.btnModels.Text = "Модели машин";
            this.btnModels.UseVisualStyleBackColor = true;
            this.btnModels.Visible = false;
            this.btnModels.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnOrders.Location = new System.Drawing.Point(135, 156);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(167, 63);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnManagers
            // 
            this.btnManagers.Location = new System.Drawing.Point(135, 287);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Size = new System.Drawing.Size(166, 56);
            this.btnManagers.TabIndex = 4;
            this.btnManagers.Text = "Менеджеры";
            this.btnManagers.UseVisualStyleBackColor = true;
            this.btnManagers.Visible = false;
            this.btnManagers.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TapTaxi.Properties.Resources.original_1pzp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 375);
            this.Controls.Add(this.btnManagers);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnModels);
            this.Controls.Add(this.btnPassengers);
            this.Controls.Add(this.btnTaxist);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TapTaxi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaxist;
        private System.Windows.Forms.Button btnPassengers;
        private System.Windows.Forms.Button btnModels;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnManagers;
    }
}

