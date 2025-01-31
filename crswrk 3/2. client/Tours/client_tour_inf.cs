using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crswrk_3._2._client.Tours
{
    public partial class client_tour_inf : Form
    {
        public client_tour_inf()
        {
            InitializeComponent();
        }

        // возврат в аккаунт
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Show();
        }

        // просмотр моих туров
        private void button2_Click(object sender, EventArgs e)
        {
            // считываем данные текущего клиента
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            label1.Text = current_client.Chosen_tours.CatalogString(current_client.Chosen_tours);
        }

        // просмотр моих тур групп
        private void button3_Click(object sender, EventArgs e)
        {
            // считываем данные текущего клиента
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            // считываем все тур группы
            string group_filePath = "Tour_group.json";
            AllTourGroups allGroups = new AllTourGroups();
            allGroups = allGroups.ReadGroupData(group_filePath);

            // выводим группы клиента
            string st = allGroups.GroupClientString(allGroups, current_client);
            label2.Text = st;

        }
    }
}
