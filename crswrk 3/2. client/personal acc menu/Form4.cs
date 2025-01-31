using crswrk_3._2._client.Tours;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crswrk_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // возвращение на главную страницу
        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        // просмотр своих данных
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LKData = new LK_data();
            LKData.Show();

        }

        // просмотр туров
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var TourForm = new Tours();
            TourForm.Show();
        }

        // оплата тура
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var payment = new Payment();
            payment.Show();
        }

        // посмотреть информацию о моих турах
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inf = new client_tour_inf();
            inf.Show();
        }
    }
}
