using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crswrk_3._3._manager.man_client_information
{
    public partial class Show_client_inf : Form
    {
        public Show_client_inf()
        {
            InitializeComponent();
        }

        // возврат в аккаунт менеджера
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var acc = new manager_acc();
            acc.Show();
        }

        // краткий вывод всех клиентов
        private void button2_Click(object sender, EventArgs e)
        {
            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            label3.Text = allClients.ClientDataString(allClients);
        }

        // вывод полной информации о клиенте
        private void button3_Click(object sender, EventArgs e)
        {
            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            string name = Convert.ToString(textBox1.Text);
            int passwort = Convert.ToInt32(textBox2.Text);

            // находим нужного клиента
            private_data current_client = new private_data();

            bool Flag = allClients.FindClient(name, passwort, allClients);

            if (!Flag)
            {
                label4.Text = "No client found!";
            }
            else
            {
                int index = allClients.ClientIndex(name, passwort, allClients);
                current_client = allClients.Clients[index];

                label4.Text = current_client.FullClientString(current_client);
            }
        }
    }
}
