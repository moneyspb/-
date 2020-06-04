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
using TapTaxi.Entities;

namespace TapTaxi
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {
            dataGridView1.DataSource = null;

            if (comboBox1.SelectedIndex == 0)
                dataGridView1.DataSource = Controller.Orders.Where(t => t.Status == StatusOrder.New).ToList();
            else if (comboBox1.SelectedIndex == 1)
                dataGridView1.DataSource = Controller.Orders.Where(t => t.Status == StatusOrder.Accepted || t.Status == StatusOrder.Assigned).ToList();
            else if (comboBox1.SelectedIndex == 2)
                dataGridView1.DataSource = Controller.Orders.Where(t => t.Status == StatusOrder.Completed).ToList();
            else
                dataGridView1.DataSource = Controller.Orders.Where(t => t.Status == StatusOrder.Failed || t.Status == StatusOrder.Canceled).ToList();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOrderForm form = new NewOrderForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateData();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Order order = dataGridView1.SelectedRows[0].DataBoundItem as Order;

                NewOrderForm form = new NewOrderForm(order);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateData();
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Order order = dataGridView1.SelectedRows[0].DataBoundItem as Order;
                if (order.Taxist != null)
                    order.Taxist.IsBusy = false;
                Controller.Remove(order);
                UpdateData();
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            UpdateData();

            comboBox1.SelectedIndex = 0;
        }

        private void ChangeStatus(StatusOrder status)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Order order = dataGridView1.SelectedRows[0].DataBoundItem as Order;
                StatusManager.ChangeStatus(order, status);

                Controller.SaveChanges();

                UpdateData();
            }
        }

        private void забралПассажираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeStatus(StatusOrder.Accepted);
        }

        private void поездкаЗавершенаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeStatus(StatusOrder.Completed);
        }

        private void поездкаОтмененаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeStatus(StatusOrder.Canceled);
        }

        private void пассажирНеОтвечаетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeStatus(StatusOrder.Failed);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}