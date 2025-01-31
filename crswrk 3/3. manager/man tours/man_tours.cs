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
    public partial class man_tours : Form
    {
        public man_tours()
        {
            InitializeComponent();
        }

        // возвращение в аккаунт
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m_acc = new manager_acc();
            m_acc.Show();
        }

        // показать все доступные туры
        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "Tour_data.json";

            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(filePath);

            label1.Text = catalog.ShortTourNames(catalog);
        }

        // выводим информацию о туре
        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = "Tour_data.json";

            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(filePath);

            string t_name = Convert.ToString(textBox1.Text);

            // проверяем есть ли тур и ищем его индекс
            bool Flag = catalog.FindTour(t_name, catalog);
            if (Flag)
            {
                int index = catalog.TourIndex(t_name, catalog);
                label1.Text = catalog.tours[index].TourStringMan(catalog.tours[index]);
            }
            else
            {
                label2.Text = "There's no such tour";
            }
        }

        // переброс на страницу, где можно состовлять туристические группы
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m_group = new make_group();
            m_group.Show();
        }
    }
}
