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
    public partial class ChangePersonalData : Form
    {
        public ChangePersonalData()
        {
            InitializeComponent();
        }

        // изменить имя
        private void button1_Click(object sender, EventArgs e)
        {
            // считываем текущего клиента
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            // ищем индекс текущего клиента
            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);

            // считываем новое имя
            string name = Convert.ToString(textBox1.Text);

            current_client.name = name;

            // записываем в данные о текущем клиенте
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов

            allClients.Clients[index] = current_client;
            allClients.WriteClientData(allClients, client_filePath);

            label12.Text = $"New username: {current_client.name}";
            label13.Text = $"New password: {current_client.pass_n}";
        }

        // изменить дату рождения
        private void button2_Click(object sender, EventArgs e)
        {
            // считываем текущего клиента
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            // ищем индекс текущего клиента
            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);

            // считываем новую дату рождения
            int year_b = 0;
            int month_b = 0;
            int day_b = 0;

            try
            {
                year_b = Convert.ToInt32(textBox2.Text);
                month_b = Convert.ToInt32(textBox6.Text);
                day_b = Convert.ToInt32(textBox7.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: day, month and year must be numbers. ",
                    "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DateOnly birth_date = new DateOnly(year_b, month_b, day_b);

            current_client.birth_date = birth_date;

            // записываем в данные о текущем клиенте
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов

            allClients.Clients[index] = current_client;
            allClients.WriteClientData(allClients, client_filePath);

            label12.Text = $"New username: {current_client.name}";
            label13.Text = $"New password: {current_client.pass_n}";
        }

        // изменить номер и серию паспорта
        private void button3_Click(object sender, EventArgs e)
        {
            // считываем текущего клиента
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            // ищем индекс текущего клиента
            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);

            // считываем новые паспортные данные
            int pass_s = -1;
            int pass_n = -1;

            try
            {
                pass_s = Convert.ToInt32(textBox3.Text);
                pass_n = Convert.ToInt32(textBox8.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: passport number and series must be numbers. ",
                    "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            current_client.pass_s = pass_s;
            current_client.pass_n = pass_n;

            // записываем в данные о текущем клиенте
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов

            allClients.Clients[index] = current_client;
            allClients.WriteClientData(allClients, client_filePath);

            label12.Text = $"New username: {current_client.name}";
            label13.Text = $"New password: {current_client.pass_n}";
        }

        // изменить параметры выдачи паспорта
        private void button4_Click(object sender, EventArgs e)
        {
            // считываем текущего клиента
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            // ищем индекс текущего клиента
            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);

            // считываем новые паспортные данные
            int year_pass = 0;
            int month_pass = 0;
            int day_pass = 0;

            try
            {
                year_pass = Convert.ToInt32(textBox4.Text);
                month_pass = Convert.ToInt32(textBox9.Text);
                day_pass = Convert.ToInt32(textBox10.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: day, month and year must be numbers. ",
                    "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DateOnly pass_date = new DateOnly(year_pass, month_pass, day_pass);

            string pass_given = Convert.ToString(textBox9.Text);

            current_client.pass_date = pass_date;
            current_client.pass_given = pass_given;

            // записываем в данные о текущем клиенте
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов

            allClients.Clients[index] = current_client;
            allClients.WriteClientData(allClients, client_filePath);

            label12.Text = $"New username: {current_client.name}";
            label13.Text = $"New password: {current_client.pass_n}";
        }

        // возврат к моим данным
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lk = new LK_data();
            lk.Show();
        }
    }
}
