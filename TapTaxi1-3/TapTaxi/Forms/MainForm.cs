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
using TapTaxi.Forms;

namespace TapTaxi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTaxist_Click(object sender, EventArgs e)
        {
            TaxistForm form = new TaxistForm();
            form.ShowDialog();
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelForm form = new ModelForm();
            form.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ApplicationHelper.CurrentRole == Role.Admin)
            {
                btnModels.Visible = true;
                btnManagers.Visible = true;
            }
        }
    }
}
