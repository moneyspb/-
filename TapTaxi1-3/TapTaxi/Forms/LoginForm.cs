using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TapTaxi.Core;

namespace TapTaxi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string phone = maskedTextBox1.Text;
            string password = txtBxPassword.Text;

            if (Controller.People.Count > 0)
            {
                var rr = Controller.People.ToList();

                Person person = Controller.People.FirstOrDefault(t => t.Phone == phone && t.Password == password);
                if (person == null)
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }
                else
                {
                    if (person is Manager)
                    {
                        Manager manager = person as Manager;
                        if (manager.IsAdmin)
                            ApplicationHelper.CurrentRole = Role.Admin;
                        else
                            ApplicationHelper.CurrentRole = Role.Manager;

                        ApplicationHelper.CurrentManager = manager;

                        MainForm mainForm = new MainForm();
                        Hide();
                        mainForm.Show();
                        mainForm.FormClosed += MainForm_FormClosed;
                    }
                    else if(person is Client)
                    {
                        ApplicationHelper.CurrentRole = Role.Client;

                       NewOrderForm mainForm = new NewOrderForm(client: person as Client);
                        Hide();
                        mainForm.FormClosed += MainForm_FormClosed;
                        mainForm.ShowDialog();
                        
                    }
                }
            }
            else
            {
                ApplicationHelper.CurrentRole = Role.Admin;

                MainForm mainForm = new MainForm();
                Hide();
                mainForm.Show();
                mainForm.FormClosed += MainForm_FormClosed;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnregist_Click(object sender, EventArgs e)
        {
            RegClientForm form = new RegClientForm();
            form.ShowDialog();
        }
    }
}
