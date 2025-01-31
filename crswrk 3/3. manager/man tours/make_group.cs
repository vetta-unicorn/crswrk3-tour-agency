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
    public partial class make_group : Form
    {
        public make_group()
        {
            InitializeComponent();
        }

        // возврат в окно с информацией
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m_tour = new man_tours();
            m_tour.Show();
        }

        // вывести клиентов, которые записались на тур
        private void button2_Click(object sender, EventArgs e)
        {
            // считываем все туры
            string filePath = "Tour_data.json";
            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(filePath);

            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            string t_name = Convert.ToString(textBox1.Text);

            // проверяем есть ли тур и ищем его индекс
            bool Flag = catalog.FindTour(t_name, catalog);

            if (!Flag)
            {
                label2.Text = "There's no such tour";
            }
            else
            {
                label2.Text = "Selected:\n" + allClients.ShowClientTour(allClients, t_name);
            }
        }

        // добавляем клиентов в тур группы
        private void button3_Click(object sender, EventArgs e)
        {
            // считываем все туры
            string filePath = "Tour_data.json";
            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(filePath);

            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            // считываем все данные из текстбоксов
            string client_name = Convert.ToString(textBox3.Text);
            int client_number = Convert.ToInt32(textBox4.Text);
            string tour_name = Convert.ToString(textBox1.Text);

            // проверка на пустое имя тура
            if (tour_name == "")
            {
                label1.Text = "Please enter a tour's name";
            }

            // считываем все тур группы
            string group_filePath = "Tour_group.json";
            AllTourGroups allGroups = new AllTourGroups();
            allGroups = allGroups.ReadGroupData(group_filePath);

            // ищем индексы всего
            bool client_Flag = allClients.FindClient(client_name, client_number, allClients);
            bool tour_Flag = catalog.FindTour(tour_name, catalog);

            if (!client_Flag)
            {
                label6.Text = "There's no such client!";
            }

            else if (!tour_Flag)
            {
                label6.Text = "There's no such tour!";
            }
            else
            {
                int client_index = allClients.ClientIndex(client_name, client_number, allClients);
                int tour_index = catalog.TourIndex(tour_name, catalog);
                int group_index = allGroups.GroupIndex(tour_name, allGroups);

                // создаем текущего клиента
                private_data client = new private_data();
                client = allClients.Clients[client_index];

                // добавляем клиента в группу
                TourGroup current_group = new TourGroup();
                current_group = allGroups.tourGroups[group_index];
                current_group.clients.Clients.Add(client);

                label1.Text = $"{client.name} was successfully\n added to the {current_group.tour.tour_name}!\n";
            }

            // записываем все в файлы
            allGroups.WriteGroupData(allGroups, group_filePath);

        }

        // удаляем клиента из группы
        private void button4_Click(object sender, EventArgs e)
        {
            // считываем все туры
            string filePath = "Tour_data.json";
            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(filePath);

            // считываем всех клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            // считываем все данные из текстбоксов
            string client_name = Convert.ToString(textBox3.Text);
            int client_number = Convert.ToInt32(textBox4.Text);
            string tour_name = Convert.ToString(textBox1.Text);

            // проверка на пустое имя тура
            if (tour_name == "")
            {
                label1.Text = "Please enter a tour's name";
            }

            // считываем все тур группы
            string group_filePath = "Tour_group.json";
            AllTourGroups allGroups = new AllTourGroups();
            allGroups = allGroups.ReadGroupData(group_filePath);

            // проверяем на наличие
            bool client_Flag = allClients.FindClient(client_name, client_number, allClients);
            bool tour_Flag = catalog.FindTour(tour_name, catalog);

            if (!client_Flag)
            {
                label1.Text = "There's no such client!";
            }

            else if (!tour_Flag)
            {
                label1.Text = "There's no such tour!";
            }
            else
            {
                // ищем все индексы
                int client_index = allClients.ClientIndex(client_name, client_number, allClients);
                int tour_index = catalog.TourIndex(tour_name, catalog);
                // индекс для листа всех групп
                int group_index = allGroups.GroupIndex(tour_name, allGroups);
                int client_index_in_group = allGroups.tourGroups[group_index].clients.
                    ClientIndex(client_name, client_number, allGroups.tourGroups[group_index].clients);

                // создаем текущего клиента
                private_data client = new private_data();
                client = allClients.Clients[client_index];

                // удаляем клиента из группы
                allGroups.tourGroups[group_index].clients.Clients.RemoveAt(client_index_in_group);

                // обновляем информацию в файле со всеми клиентами
                allClients.Clients[client_index] = client;

                label1.Text = $"{client.name} was successfully\n deleted from {tour_name}!\n";
            }

            allGroups.WriteGroupData(allGroups, group_filePath);
        }


        // вывести группу
        private void button5_Click(object sender, EventArgs e)
        {
            // считываем все тур группы
            string group_filePath = "Tour_group.json";
            AllTourGroups allGroups = new AllTourGroups();
            allGroups = allGroups.ReadGroupData(group_filePath);

            string tour_name = Convert.ToString(textBox1.Text);

            // ищем индекс
            int group_index = allGroups.GroupIndex(tour_name, allGroups);
            label7.Text = "Group\n" + allGroups.tourGroups[group_index].GroupString(allGroups.tourGroups[group_index]);
        }
    }
}
