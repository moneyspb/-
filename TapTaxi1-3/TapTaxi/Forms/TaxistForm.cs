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
    public partial class TaxistForm : Form
    {
        public TaxistForm()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Controller.Taxists;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTaxistForm form = new NewTaxistForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateData();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Taxist taxist = dataGridView1.SelectedRows[0].DataBoundItem as Taxist;

                NewTaxistForm form = new NewTaxistForm(taxist);
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
                Taxist taxist = dataGridView1.SelectedRows[0].DataBoundItem as Taxist;

                Controller.Remove(taxist);
                UpdateData();
            }
        }

        private void TaxistForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpdateData();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
