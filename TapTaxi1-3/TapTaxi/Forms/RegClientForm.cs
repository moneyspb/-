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
    public partial class RegClientForm : Form
    {
        private Client client;

        public RegClientForm(Client client = null)
        {
            InitializeComponent();

            this.client = client;

            if (client != null)
            {
                txtBxFIO.Text = client.FIO;
                txtBxPassword.Text = client.Password;
                txtBxPasswordRepeat.Text = client.Password;
                txtBxPhone.Text = client.Phone;
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

            if (client == null)
            {
                client = Controller.Clients.FirstOrDefault(t => t.Phone == txtBxPhone.Text);
                if (client == null)
                    client = new Client();
            }

            client.FIO = txtBxFIO.Text;
            client.Password = txtBxPassword.Text;
            client.Phone = txtBxPhone.Text;
            client.Reputation = 5;

            Controller.Update(client);

            DialogResult = DialogResult.OK;
        }
    }
}
