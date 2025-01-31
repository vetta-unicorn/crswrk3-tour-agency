using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace crswrk_3
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Show();
        }


        // показать мою информацию об оплате
        private void button2_Click(object sender, EventArgs e)
        {
            // считываем данные о клиенте из файла
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);
            string st = current_client.ShowPaymentInformation(current_client);
            label3.Text = st;
        }

        // добавить мои данные об оплате в корзину
        private void button4_Click(object sender, EventArgs e)
        {
            // считываем всех клиентов
            string Client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(Client_filePath);

            // считываем данные о клиенте из файла
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            // добавляем туры в корзину
            string st = current_client.AddToCart(current_client);
            label5.Text = st;

            // ищем индекс текущего клиента
            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);

            // записываем в данные о текущем клиенте
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов
            allClients.Clients[index] = current_client;
            allClients.WriteClientData(allClients, Client_filePath);
        }

        // очистка корзины
        private void button7_Click(object sender, EventArgs e)
        {
            // считываем данные о клиенте из файла
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            // ищем индекс текущего клиента
            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);

            string st = current_client.ClearCart(current_client);
            label5.Text = st;

            // записываем в данные о текущем клиенте
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов
            allClients.Clients[index] = current_client;
            allClients.WriteClientData(allClients, client_filePath);
        }

        // переход на страницу с оплатой
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var _pay = new payment_page();
            _pay.Show();
        }
    }
}
