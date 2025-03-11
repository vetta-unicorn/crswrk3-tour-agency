using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Reflection.Emit;
using static System.Windows.Forms.DataFormats;

namespace crswrk_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // вернуться на главную
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        // авторизация для клиентов
        private void button2_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            // новый файл для сохранения текущего клиента 
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";

            // чтение данных из json файла
            string filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(filePath);
            string pass_name = "";
            int password = -1;

            // чтение данных из формы
            try
            {
                pass_name = Convert.ToString(textBox1.Text);
                password = Convert.ToInt32(textBox2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: the password must be a number ", "Input Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            bool Flag = allClients.FindClient(pass_name, password, allClients);

            if (Flag == false)
            {
                label3.Text = "Incorrect user name or password! \n Haven't registered yet? \n Register!";
            }
            else if (Flag == true)
            {
                int index = allClients.ClientIndex(pass_name, password, allClients);
                current_client = allClients.Clients[index];
                current_client.WriteCurrentData(current_client, current_filePath);

                this.Hide();
                form4.Show();
            }
        }

        //переброс на регистрацию
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
