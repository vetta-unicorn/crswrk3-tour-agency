using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crswrk_3
{
    public partial class LK_data : Form
    {
        public LK_data()
        {
            InitializeComponent();
        }

        // вернуться в личный кабине
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Show();
        }

        // посмотреть свои данные
        private void button2_Click(object sender, EventArgs e)
        {
            private_data current_client = new private_data();
            string current_filePath = "Current_client.json";
            current_client = current_client.ReadCurrentData(current_filePath);

            label1.Text = current_client.ClientString(current_client);
        }

        // изменить свои данные
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var change_data = new ChangePersonalData();
            change_data.Show();
        }
    }
}
