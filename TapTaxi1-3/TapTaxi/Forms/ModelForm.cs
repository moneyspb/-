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
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Controller.ModelCars;
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewModelForm form = new NewModelForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateData();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ModelCar modelCar = dataGridView1.SelectedRows[0].DataBoundItem as ModelCar;

                NewModelForm form = new NewModelForm(modelCar);
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
                ModelCar modelCar = dataGridView1.SelectedRows[0].DataBoundItem as ModelCar;

                Controller.Remove(modelCar);
                UpdateData();
            }
        }
    }
}
