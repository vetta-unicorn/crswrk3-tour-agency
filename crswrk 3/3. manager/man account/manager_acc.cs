using crswrk_3._3._manager.man_client_information;
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
    public partial class manager_acc : Form
    {
        public manager_acc()
        {
            InitializeComponent();
        }

        // возврат на главную
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        // переброс на страницу с турами
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m_tours = new man_tours();
            m_tours.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var database = new Show_client_inf();
            database.Show();
        }
    }
}
