using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crswrk_3
{
    public partial class payment_page : Form
    {
        public payment_page()
        {
            InitializeComponent();
        }

        // возврат в корзину
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pay = new Payment();
            pay.Show();
        }

        // ввод данных карты
        private void button4_Click(object sender, EventArgs e)
        {
            // считываем данные карты
            long card_number = (long)Convert.ToDouble(textBox1.Text);
            string card_holder = Convert.ToString(textBox2.Text);
            int card_month = Convert.ToInt32(textBox3.Text);
            int card_year = Convert.ToInt32(textBox4.Text);
            int cvc = Convert.ToInt32(textBox5.Text);
            DateOnly expiry_date = new DateOnly(card_year, card_month, 1);

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

            // вносим информацию о карте клиента
            current_client.Chosen_payments =
                current_client.Chosen_payments.AddDetails(current_client.Chosen_payments,
                card_number, expiry_date, card_holder, cvc);

            // записываем в данные о текущем клиенте
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов
            allClients.Clients[index] = current_client;
            allClients.WriteClientData(allClients, client_filePath);

        }

        // оплата
        private void button2_Click(object sender, EventArgs e)
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

            string st = "";

            st = current_client.ClientPay(current_client);

            label8.Text = st;

            // записываем в данные о текущем клиенте
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов
            allClients.Clients[index] = current_client;
            allClients.WriteClientData(allClients, client_filePath);


        }

        // вывод информации об оплате
        private void button3_Click(object sender, EventArgs e)
        {
            // считываем данные о клиенте из файла
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            if (current_client.Chosen_payments == null || current_client.Chosen_payments?.sum == 0)
            {
                label7.Text = "You have no tours in your card";
            }

            // выводим информацию
            label7.Text = current_client.Chosen_payments.PayString(current_client.Chosen_payments);

        }

    }
}
