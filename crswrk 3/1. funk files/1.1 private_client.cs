using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crswrk_3
{
    internal class private_client
    {
    }

    [Serializable]
    public class private_data : IClient
    {
        public string name { get; set; }
        public DateOnly birth_date { get; set; }
        public int pass_s { get; set; }
        public int pass_n { get; set; }
        public DateOnly pass_date { get; set; }
        public string pass_given { get; set; }
        public TourCatalog Chosen_tours { get; set; }
        public payment Chosen_payments { get; set; }

        // Инициализация списка клиентов

        public  private_data()
        {
            Chosen_tours = new TourCatalog(); // Инициализация Chosen_tours
            Chosen_payments = new payment(); // Инициализация Chosen_payments
        }

        public private_data(string _name, DateOnly _birth_date,
            int _pass_s, int _pass_n, DateOnly _pass_date, string _pass_given)
        {
            name = _name;
            birth_date = _birth_date;
            pass_s = _pass_s;
            pass_n = _pass_n;
            pass_date = _pass_date;
            pass_given = _pass_given;
            Chosen_tours = new TourCatalog();
            Chosen_payments = new payment();
        }

        // выводим данные клиенты, включая данные о всех его турах
        public string ClientString(private_data client)
        {
            string st = client.ShortClientString(client);

            if (client.Chosen_tours is not null)
            {
                st += $"My selected tours:\n{Chosen_tours.ShortCatalogString(Chosen_tours)}";
            }
            else
            {
                st += "No tour selected!";
            }
            return st;
        }

        // выводим данные клиенты, включая данные о всех его турах (их кратно)
        public string FullClientString(private_data client)
        {
            string st = client.ShortClientString(client) + "\n";

            if (client.Chosen_tours is not null)
            {
                st += $"Selected tours:\n{Chosen_tours.ShortCatalogString(Chosen_tours)}";
            }
            else
            {
                st += "No tour selected!";
            }
            return st;
        }

        // выводим информацию о клиенте и одном его туре added / payed
        public string TourCLientString(private_data client, Tour tour)
        {
            string st = client.ShortClientString(client);
            int index = client.Chosen_tours.TourIndex(tour.tour_name, client.Chosen_tours);
            st += $"Added to the cart: {client.Chosen_tours.tours[index].added}\n" +
                $"Payed: {client.Chosen_tours.tours[index].added}\n\n";
            return st;
        }

        // выводим только личные данные клиента
        public string ShortClientString(private_data client)
        {
            string st = $"Name: {name};\nBirth date: {birth_date};\nPassport series: {pass_s};\n" +
                $"Passport number:  {pass_n};\nPassport issue date: {pass_date};\n" +
                $"Passport issue place: {pass_given}\n";
            return st;
        }

        // выводим оплачен ли у него тур
        public string CLientStringWithPayed(private_data client, string t_name)
        {
            string st = ShortClientString(client);
            int index = client.Chosen_tours.TourIndex(t_name, client.Chosen_tours);
            st += $"Added to the cart: {client.Chosen_tours.tours[index].added}\n" +
                $"Payed: {client.Chosen_tours.tours[index].payed}\n\n";

            return st;
        }

        // Запись данных в JSON файл
        public void WriteCurrentData(private_data client, string filePath)
        {
            string updatedJson = JsonConvert.SerializeObject(client, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }

        // Чтение данных из json файла
        public private_data ReadCurrentData(string filePath)
        {
            private_data client = new private_data();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                client = JsonConvert.DeserializeObject<private_data>(json) ?? new private_data();
            }

            return client;
        }

        // оплата тура
        public string ClientPay(private_data client)
        {
            string st = "";

            // проверка что данные карты введены
            if (!client.Chosen_payments.IfCardNumberIsNull(client.Chosen_payments))
            {
                st = "You haven't linked a card yet!\nPlease add the card details.\n";
            }

            // проверка что корзина не пуста
            else if (!client.Chosen_payments.IfSumIsNull(client.Chosen_payments))
            {
                st = "Your cart is empty!\nThere's nothing to pay";
            }

            else
            {
                // зануляем корзину
                client.Chosen_payments.sum = 0;

                // если тур был добавлен, но еще не оплачен, то оплачиваем его
                foreach (var tour in client.Chosen_tours.tours)
                {
                    if (tour.added == true && tour.payed == false)
                    {
                        tour.added = false;
                        tour.payed = true;
                        st += $"{tour.tour_name} was succesfully payed!\n";
                    }
                }
            }

            return st;
        }

        // выбор тура
        public string SelectTour(private_data client, TourCatalog catalog, string tour_name)
        {
            string st = "";

            // ищем индекс нужного тура
            int tourIndex = catalog.TourIndex(tour_name, catalog);

            // выбираем по индексу нужный тур
            Tour selected_tour = new Tour();
            selected_tour = catalog.tours[tourIndex];

            if (client.Chosen_tours == null)
            {
                // Инициализируем Chosen_tours
                client.Chosen_tours = new TourCatalog();
            }

            // Теперь можно safely добавлять тур в список
            bool flag = client.Chosen_tours.FindTour(selected_tour.tour_name, client.Chosen_tours);
            if (!flag)
            {
                client.Chosen_tours.tours.Add(selected_tour);
                st = $"You have selected tour '{selected_tour.tour_name}'";
            }
            else
            {
                st = "You have already selected this tour!";
            }
            return st;
        }

        // показать мои данные об оплате
        public string ShowPaymentInformation(private_data client)
        {
            string st = "My selected tours:\n";

            if (client.Chosen_tours is null)
            {
                st = "You haven't selected any tour yet!";
            }
            else
            {
                int h = 0;
                foreach (var tour in client.Chosen_tours.tours)
                {
                    st += $"{tour.tour_name}, cost: {tour.cost}\n";
                    // делаем проверку, что количество туров в корзине больше, чем счётчик
                    if (client.Chosen_tours.tours.Count() > h)
                    {

                        if (client.Chosen_tours.tours[h].payed)
                        {
                            st += "You have already payed for this tour!\n\n";
                        }

                        else if (client.Chosen_tours.tours[h].added)
                        {
                            st += "You have already put this tour to the cart!\n\n";
                        }
                    }
                    h++;
                }
                st += "\n";
            }
            return st;
        }

        public string AddToCart(private_data client)
        {
            string st = "";

            // проверка на null оплату
            if (client.Chosen_payments == null)
            {
                client.Chosen_payments = new payment();
            }

            // делаем проверку на то что информация об оплатах пуста
            if (client.Chosen_payments.sum == 0)
            {
                // добавляем выбранные туры в корзину
                foreach (var tour in client.Chosen_tours.tours)
                {
                    if (!tour.added && !tour.payed)
                    {
                        tour.added = true;
                        client.Chosen_payments.sum += tour.cost;
                        st += $"{tour.tour_name} was successfully added to the cart\n\n";
                    }
                }
            }

            else
            {
                // добавляем в корзину туры, которых там еще нет
                foreach (var tour in client.Chosen_tours.tours)
                {
                    if (tour.payed)
                    {
                        st += $"{tour.tour_name} has been already payed!\nYou can't add it twice\n\n";
                    }
                    else if (tour.added)
                    {
                        st += $"{tour.tour_name} has been already in the cart\nYou can't add it twice\n\n";

                    }
                    else if (!tour.added)
                    {
                        tour.added = true;
                        client.Chosen_payments.sum += tour.cost;
                        st += $"{tour.tour_name} was successfully added to the cart\n\n";
                    }
                }
            }

            return st;
        }

        // очищаем корзину
        public string ClearCart(private_data client)
        {
            client.Chosen_payments.sum = 0;
            foreach (var tour in client.Chosen_tours.tours)
            {
                tour.added = false;
            }

            return "Your cart was cleared";
        }

        public bool FindTourClient(private_data client, string t_name)
        {
            bool Flag = false;

            // перебираем все туры клиента
            foreach(var tour in client.Chosen_tours.tours)
            {
                if(tour.tour_name == t_name)
                {
                    Flag = true;
                }
            }

            return Flag;
        }

    }
}
