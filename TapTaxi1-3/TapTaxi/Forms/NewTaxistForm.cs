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
    public partial class NewTaxistForm : Form
    {
        private Taxist taxist;

        public NewTaxistForm(Taxist taxist = null)
        {
            InitializeComponent();

            comboBoxModel.DataSource = Controller.ModelCars;

            if (taxist != null)
            {
                txtBxFIO.Text = taxist.FIO;
                txtBxNumberCar.Text = taxist.NumberCar;
                txtBxPhone.Text = taxist.Phone;
                comboBoxColor.SelectedItem = taxist.Color;
                comboBoxModel.SelectedItem = taxist.Model;

                this.taxist = taxist;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtBxFIO.Text == "" || txtBxNumberCar.Text == "" || txtBxPhone.Text == "" ||
                comboBoxColor.SelectedItem == null || comboBoxModel.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            int id = taxist == null ? 0 : taxist.Id;

            if (Controller.Taxists.FirstOrDefault(t => t.Phone == txtBxPhone.Text && t.Id != id) != null)
            {
                MessageBox.Show("Водитель с таким телефоном уже существует!");
                return;
            }

            if (taxist == null)
                taxist = new Taxist();

            taxist.FIO = txtBxFIO.Text;
            taxist.Color = comboBoxColor.SelectedItem.ToString();
            taxist.Model = comboBoxModel.SelectedItem as ModelCar;
            taxist.NumberCar = txtBxNumberCar.Text;
            taxist.Phone = txtBxPhone.Text;

            Controller.Update(taxist);

            DialogResult = DialogResult.OK;
        }
    }
}
