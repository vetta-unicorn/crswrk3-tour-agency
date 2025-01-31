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
    public partial class Tours : Form
    {
        public Tours()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Show();
        }

        // вывести Road movie
        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "Tour_data.json";

            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(filePath);

            int tourIndex = catalog.TourIndex("Road movie", catalog);
            label3.Text = catalog.tours[tourIndex].TourString(catalog.tours[tourIndex]);
        }

        // вывести Winter wonderland
        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = "Tour_data.json";

            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(filePath);

            int tourIndex = catalog.TourIndex("Winter wonderland", catalog);
            label3.Text = catalog.tours[tourIndex].TourString(catalog.tours[tourIndex]);
        }

        // вывести Ancient soul
        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = "Tour_data.json";

            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(filePath);

            int tourIndex = catalog.TourIndex("Ancient soul", catalog);
            label3.Text = catalog.tours[tourIndex].TourString(catalog.tours[tourIndex]);
        }

        // select road movie
        private void button5_Click(object sender, EventArgs e)
        {
            // читаем информацию текущего клиента из json
            string current_filePath = "Current_client.json";
            private_data current_client = new private_data();
            current_client = current_client.ReadCurrentData(current_filePath);

            // читаем информацию о всех турах
            string tour_filePath = "Tour_data.json";
            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(tour_filePath);

            string st = current_client.SelectTour(current_client, catalog, "Road movie");

            label5.Text = st;

            // обновляем информацию текущего клиента
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);
            allClients.Clients[index] = current_client;

            allClients.WriteClientData(allClients, client_filePath);
        }

        // select Winter wonderland
        private void button6_Click(object sender, EventArgs e)
        {
            // читаем информацию текущего клиента из json
            string current_filePath = "Current_client.json";
            private_data current_client = new private_data();
            current_client = current_client.ReadCurrentData(current_filePath);

            // читаем информацию о всех турах
            string tour_filePath = "Tour_data.json";
            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(tour_filePath);

            string st = current_client.SelectTour(current_client, catalog, "Winter wonderland");

            label5.Text = st;

            // обновляем информацию текущего клиента
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);
            allClients.Clients[index] = current_client;

            allClients.WriteClientData(allClients, client_filePath);
        }

        // select ancient soul
        private void button7_Click(object sender, EventArgs e)
        {
            // читаем информацию текущего клиента из json
            string current_filePath = "Current_client.json";
            private_data current_client = new private_data();
            current_client = current_client.ReadCurrentData(current_filePath);

            // читаем информацию о всех турах
            string tour_filePath = "Tour_data.json";
            TourCatalog catalog = new TourCatalog();
            catalog = catalog.ReadTourData(tour_filePath);

            string st = current_client.SelectTour(current_client, catalog, "Ancient soul");

            label5.Text = st;

            // обновляем информацию текущего клиента
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);
            allClients.Clients[index] = current_client;

            allClients.WriteClientData(allClients, client_filePath);
        }

        // отменить выбор тура
        private void button8_Click(object sender, EventArgs e)
        {
            // читаем информацию текущего клиента из json
            string current_filePath = "Current_client.json";
            private_data current_client = new private_data();
            current_client = current_client.ReadCurrentData(current_filePath);

            // очищаем поле и записываем в файл
            current_client.Chosen_tours = null;
            //current_client.Chosen_payments.cart = 0;
            current_client.WriteCurrentData(current_client, current_filePath);

            // переносим информацию в общий файл клиентов
            string client_filePath = "Client_data.json";
            ClientData allClients = new ClientData();
            allClients = allClients.ReadClientData(client_filePath);

            int index = allClients.ClientIndex(current_client.name, current_client.pass_n, allClients);
            allClients.Clients[index] = current_client;

            allClients.WriteClientData(allClients, client_filePath);
        }
    }
}
