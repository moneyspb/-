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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Controller.Clients;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegClientForm form = new RegClientForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateData();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Client client = dataGridView1.SelectedRows[0].DataBoundItem as Client;

                RegClientForm form = new RegClientForm(client);
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
                Client client = dataGridView1.SelectedRows[0].DataBoundItem as Client;

                Controller.Remove(client);
                UpdateData();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            UpdateData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
