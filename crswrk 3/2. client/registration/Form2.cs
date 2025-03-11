using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace crswrk_3
{

    [Serializable]
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // возвращение на главную страницу
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            //form1.main = this;
            form1.Show();
        }

        // регистрация
        private void button2_Click(object sender, EventArgs e)
        {
            // Считывание информации

            string name = Convert.ToString(textBox1.Text);

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

            string pass_given = Convert.ToString(textBox5.Text);

            // Создание экземпляра классов

            ClientData all_clients = new ClientData();
            var client = new private_data(name, birth_date, pass_s, pass_n, pass_date, pass_given);


            // Сериализация

            string filePath = "Client_data.json";
            all_clients = all_clients.ReadClientData(filePath);

            if (all_clients.Clients == null)
            {
                all_clients.Clients = new List<private_data>();
            }

            all_clients.AddClientData(client, filePath);

            label12.Text = "Data entry";
            label13.Text = "Your username:" + ' ' + name;
            label14.Text = "Your password:" + ' ' + pass_n;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
