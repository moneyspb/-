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
    public partial class NewManagerForm : Form
    {
        private Manager manager;

        public NewManagerForm(Manager manager = null)
        {
            InitializeComponent();
        
            if (manager != null)
            {
                this.manager = manager;
                txtBxFIO.Text = manager.FIO;
                txtBxPassword.Text = manager.Password;
                txtBxPasswordRepeat.Text = manager.Password;
                txtBxPhone.Text = manager.Phone;
                checkBox1.Checked = manager.IsAdmin;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtBxPassword.Text != txtBxPasswordRepeat.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if (txtBxFIO.Text == "" || txtBxPassword.Text == "" || txtBxPhone.Text == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            int id = manager == null ? 0 : manager.Id;

            if (Controller.Managers.FirstOrDefault(t => t.Phone == txtBxPhone.Text && t.Id != id) != null)
            {
                MessageBox.Show("Менеджер с таким телефоном уже существует!");
                return;
            }

            if (manager == null)
                manager = new Manager();

            manager.FIO = txtBxFIO.Text;
            manager.Password = txtBxPassword.Text;
            manager.Phone = txtBxPhone.Text;
            manager.IsAdmin = checkBox1.Checked;

            Controller.Update(manager);

            DialogResult = DialogResult.OK;
        }
    }
}
