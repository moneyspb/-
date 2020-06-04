using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TapTaxi.Core;

namespace TapTaxi
{
    public partial class NewOrderForm : Form
    {
        private Order order;
        private Client client;
        private int distance;
        Random random = new Random();
        int probki;

        public NewOrderForm(Order order = null, Client client = null)
        {
            InitializeComponent();

            this.client = client;

            if (client == null)
            {
                comboBoxDriver.DataSource = Controller.Taxists.Where(t => t.IsBusy == false).ToList();

                if (order != null)
                {
                    this.order = order;

                    maskedTextBox1.Text = order.Client?.Phone;
                    txtBxCost.Text = order.Cost.ToString("c");
                    txtBxFrom.Text = order.FromPlace;
                    txtBxTo.Text = order.ToPlace;
                    comboBoxDriver.SelectedItem = order.Taxist;
                }
            }
            else
            {
                maskedTextBox1.Visible = false;
                dateTimePicker1.Visible = false;
                comboBoxDriver.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;

                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].Location = new Point(Controls[i].Location.X, Controls[i].Location.Y - 120);
                }

                Height -= 90;
            }

            probki = random.Next(0, 10);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtBxFrom.Text == "" || txtBxTo.Text == "")
            {
                MessageBox.Show("Введите пункт отправления и назначения");
                return;
            }

            if (btnCalcCost.Enabled == true)
            {
                MessageBox.Show("Выполните расчет стоимости заказа");
                return;
            }

            if (order == null)
                order = new Order();

            if (client == null)
            {
                client = Controller.Clients.FirstOrDefault(t => t.Phone == maskedTextBox1.Text);
                if (client == null)
                {
                    client = new Client();
                    client.Phone = maskedTextBox1.Text;
                }
            }

            order.Cost = decimal.Parse(txtBxCost.Text, System.Globalization.NumberStyles.Currency);
            order.Date = dateTimePicker1.Value;
            order.FromPlace = txtBxFrom.Text;
            order.ToPlace = txtBxTo.Text;
            order.Taxist = comboBoxDriver.SelectedItem as Taxist;
            order.Client = client;
            if (order.Taxist != null)
            {
                order.Status = StatusOrder.Assigned;
                order.Taxist.IsBusy = true;
            }
            else
                order.Status = StatusOrder.New;

            if (client.Reputation <= 2)
            {
                if (MessageBox.Show("Обратите внимание на плохую репутацию клиента! Продолжить?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            Controller.Update(order);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCalcCost_Click(object sender, EventArgs e)
        {
            txtBxCost.Text = WinManager.cost_trip(distance, comboBoxTariff.SelectedIndex, probki).ToString("c");
            btnCalcCost.Enabled = false;
        }

        private void txtBxFrom_TextChanged(object sender, EventArgs e)
        {
            distance = random.Next(2, 10);
            btnCalcCost.Enabled = true;
        }

        private void comboBoxTariff_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCalcCost.Enabled = true;
        }
    }

}

       