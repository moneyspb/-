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

namespace TapTaxi.Forms
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Controller.Managers;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewManagerForm form = new NewManagerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateData();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Manager manager = dataGridView1.SelectedRows[0].DataBoundItem as Manager;

                NewManagerForm form = new NewManagerForm(manager);
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
                Manager manager = dataGridView1.SelectedRows[0].DataBoundItem as Manager;

                Controller.Remove(manager);
                UpdateData();
            }
        }
    }
}
