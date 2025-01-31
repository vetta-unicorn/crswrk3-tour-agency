using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace crswrk_3
{
    internal class _1
    {
    }

    // класс туристическая группа
    public class TourGroup : IClient, IPoint
    {
        // свойства из IClient
        public string name { get; set; }
        public DateOnly birth_date { get; set; }
        public int pass_s { get; set; }
        public int pass_n { get; set; }
        public DateOnly pass_date { get; set; }
        public string pass_given { get; set; }

        //  свойства из IPoint
        public string point_name { get; set; }
        public int point_days { get; set; }
        public string hotel_name { get; set; }
        public int hotel_stars { get; set; }

        public excursion exc { get; set; }

        // группа
        public ClientData clients { get; set; }

        // сопровождающий
        public manager accompanying { get; set; }

        // тур
        public Tour tour { get; set; }

        // методы
        public TourGroup()
        {
            clients = new ClientData();
            accompanying = new manager();
            tour = new Tour();
        }

        public string GroupString(TourGroup group)
        {
            string st = $"Name: {tour.tour_name}\nCost: {tour.cost}\nNumber of days: {tour.tour_days}\n" +
                $"Accompanyng: {accompanying.name}\n\n";
            st += group.clients.ClientDataString(group.clients);
            return st;
        }

        public string GroupStringClient(TourGroup group)
        {
            string st = $"Name: {tour.tour_name}\nCost: {tour.cost}\nNumber of days: {tour.tour_days}\n" +
                $"Accompanyng: {accompanying.name}\n\n";
            return st;
        }
    }

    public class AllTourGroups : IClient, IPoint
    {
        // свойства из IClient
        public string name { get; set; }
        public DateOnly birth_date { get; set; }
        public int pass_s { get; set; }
        public int pass_n { get; set; }
        public DateOnly pass_date { get; set; }
        public string pass_given { get; set; }

        //  свойства из IPoint
        public string point_name { get; set; }
        public int point_days { get; set; }
        public string hotel_name { get; set; }
        public int hotel_stars { get; set; }

        public excursion exc { get; set; }

        // лист тур групп
        public List<TourGroup> tourGroups { get; set; }

        // методы

        public AllTourGroups()
        {
            tourGroups = new List<TourGroup>();
        }

        // запись данных в json файл
        public void AddGroupData(TourGroup newGroup, string filePath)
        {
            // Чтение существующих данных из JSON файла
            AllTourGroups allGroups = ReadGroupData(filePath);

            // Добавление нового клиента
            allGroups.tourGroups.Add(newGroup);

            WriteGroupData(allGroups, filePath);
        }

        // Запись данных в JSON файл
        public void WriteGroupData(AllTourGroups allGroups, string filePath)
        {
            string updatedJson = JsonConvert.SerializeObject(allGroups, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }

        // Чтение данных из json файла
        public AllTourGroups ReadGroupData(string filePath)
        {
            AllTourGroups toursList = new AllTourGroups();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                toursList = JsonConvert.DeserializeObject<AllTourGroups>(json) ?? new AllTourGroups();
            }

            if (toursList.tourGroups == null)
            {
                toursList.tourGroups = new List<TourGroup>();
            }

            return toursList;
        }

        // ищем индекс нужной группы
        public int GroupIndex(string name, AllTourGroups allGroups)
        {
            int index = 0;
            foreach (var group in allGroups.tourGroups)
            {
                if (group.tour.tour_name == name)
                {
                    break;
                }
                index++;
            }
            return index;
        }

        // выводит все группы клиента
        public string GroupClientString(AllTourGroups allGroups, private_data current_client)
        {

            string st = "";

            foreach (var group in allGroups.tourGroups)
            {
                foreach (var client in group.clients.Clients)
                {
                    if (client.name == current_client.name)
                    {
                        st += group.GroupStringClient(group);
                    }
                }
            }

            return st;
        }
    }
}
