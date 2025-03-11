using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crswrk_3
{
    public partial class manager_log : Form
    {
        public manager_log()
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

        // вход
        private void button2_Click(object sender, EventArgs e)
        {
            // новый файл для менеджеров
            manager curr_man = new manager();
            string man_filePath = "Current_manager.json";

            // чтение всех менеджеров
            string filePath = "ManagerData.json";
            manager_catalog man_catalog = new manager_catalog();
            man_catalog = man_catalog.ReadManagerCatalogData(filePath);

            // чтение данных из формы
            string pass_name = Convert.ToString(textBox1.Text);
            int password = -1;

            try
            { 
                password = Convert.ToInt32(textBox2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: password must be a number. ",
                    "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool Flag = man_catalog.FindManager(pass_name, password, man_catalog);

            if (!Flag)
            {
                label3.Text = "Incorrect username or password!\nTry again or ask administrator!";
            }
            else
            {
                int index = man_catalog.ManagerIndex(pass_name, password, man_catalog);
                curr_man = man_catalog.managers[index];
                curr_man.WriteManagerData(curr_man, man_filePath);
                this.Hide();
                var m_log = new manager_acc();
                m_log.Show();
            }

        }
    }
}
