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
    public partial class NewModelForm : Form
    {
        private ModelCar modelCar;

        public NewModelForm(ModelCar modelCar = null)
        {
            InitializeComponent();
        
            if (modelCar != null)
            {
                txtBxName.Text = modelCar.Name;
                this.modelCar = modelCar;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtBxName.Text == "")
            {
                MessageBox.Show("Укажите название модели");
                return;
            }

            if (modelCar == null)
                modelCar = new ModelCar();

            modelCar.Name = txtBxName.Text;
            Controller.Update(modelCar);

            DialogResult = DialogResult.OK;
        }
    }
}
