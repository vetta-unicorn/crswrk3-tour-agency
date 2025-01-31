using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crswrk_3
{
    internal class route
    {
    }

    [Serializable]
    public class Point_place : IPoint
    {
        public string point_name { get; set; }
        public int point_days { get; set; }
        public string hotel_name { get; set; }
        public int hotel_stars { get; set; }
        public excursion exc { get; set; }

        public Point_place(string _name, int _days, string _hotel_name, int _hotel_stars, excursion _exc)
        {
            point_name = _name;
            point_days = _days;
            hotel_name = _hotel_name;
            hotel_stars = _hotel_stars;
            exc = _exc;
        }

        public string PointString(Point_place point)
        {
            string st = $"Name: {point_name};\nNumber of days: {point_days};\nHotel name: {hotel_name};\n" +
                $"Hotel stars:  {hotel_stars};\nExcurssion program: {exc};\n";
            return st;
        }

    }

    public class Tour : IPoint
    {
        public string point_name { get; set; }
        public int point_days { get; set; }
        public string hotel_name { get; set; }
        public int hotel_stars { get; set; }
        public excursion exc { get; set; }

        public string tour_name { get; set; }
        public string country {  get; set; }
        public int tour_days { get; set; }
        public double cost { get; set; }
        public bool payed { get; set; }
        public bool added { get; set; }
        public List<Point_place> points { get; set; }

        public Tour()
        {
            payed = false;
            added = false;
            points = new List<Point_place>();
        }

        public Tour(string t_name, string cntr, int t_days, double cst)
        {
            payed = false;
            added = false;
            tour_name = t_name;
            country = cntr;
            tour_days = t_days;
            cost = cst;
            points = new List<Point_place>();
        }

        public string TourString(Tour tour)
        {
            string st = $"Tour name: {tour_name};\nCountry: {country};\nNumber of days: {tour_days};\n" +
                $"Cost: {cost} RUB\nAdded to the cart: {added}\nPayed: {payed}\n\n";
            st += "Points:\n";
            int id = 1;
            foreach (var point in tour.points)
            {
                st += $"{Convert.ToString(id)}. {point.PointString(point)}\n";
                id++;
            }
            return st;
        }

        public string TourStringMan(Tour tour)
        {
            string st = $"Tour name: {tour_name};\nCountry: {country};\nNumber of days: {tour_days};\n" +
                $"Cost: {cost} RUB\n\n";
            st += "Points:\n";
            int id = 1;
            foreach (var point in tour.points)
            {
                st += $"{Convert.ToString(id)}. {point.PointString(point)}\n";
                id++;
            }
            return st;
        }

        public string ShortTourString(Tour tour)
        {
            string st = $"Tour name: {tour_name}\nAdded to the cart: {added}\nPayed: {payed}";
            return st;
        }

    }

    public class TourCatalog : IPoint
    {
        public string point_name { get; set; }
        public int point_days { get; set; }
        public string hotel_name { get; set; }
        public int hotel_stars { get; set; }
        public excursion exc { get; set; }
        public string tour_name { get; set; }
        public string country { get; set; }
        public int tour_days { get; set; }
        public double cost {  get; set; }
        public List<Point_place> points { get; set; }

        public List<Tour> tours { get; set; }

        public TourCatalog()
        {
            tours = new List<Tour>();
        }

        // запись данных в json файл
        public void AddTourData(Tour newTour, string filePath)
        {
            // Чтение существующих данных из JSON файла
            TourCatalog allTours = ReadTourData(filePath);

            // Добавление нового клиента
            allTours.tours.Add(newTour);

            WriteTourData(allTours, filePath);
        }

        // Запись данных в JSON файл
        public void WriteTourData(TourCatalog allTours, string filePath)
        {
            string updatedJson = JsonConvert.SerializeObject(allTours, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }

        // Чтение данных из json файла
        public TourCatalog ReadTourData(string filePath)
        {
            TourCatalog tourList = new TourCatalog();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                tourList = JsonConvert.DeserializeObject<TourCatalog>(json) ?? new TourCatalog();
            }

            return tourList;
        }

        public string CatalogString(TourCatalog catalog)
        {
            string st = "";
            foreach (var tour in catalog.tours)
            {
                st += $"{tour.TourString(tour)}\n\n";
            }
            return st;
        }

        public string ShortCatalogString(TourCatalog catalog)
        {
            string st = "";
            foreach (var tour in catalog.tours)
            {
                st += $"{tour.ShortTourString(tour)}\n\n";
            }
            return st;
        }

        public string ShortTourNames(TourCatalog catalog)
        {
            string st = "";
            foreach(var tour in catalog.tours)
            {
                st += $"Tour name: {tour.tour_name}\nNumber of days: {tour.tour_days}\nCost: {tour.cost}\n\n";
            }
            return st;
        }

        public int TourIndex(string name, TourCatalog allTours)
        {
            int index = 0;
            foreach (var tour in allTours.tours)
            {
                if (tour.tour_name == name)
                {
                    break;
                }
                index++;
            }
            return index;
        }

        public bool FindTour(string name, TourCatalog allTours)
        {
            bool Flag = false;
            foreach (var tour in allTours.tours)
            {
                if (tour.tour_name == name)
                {
                    Flag = true;
                    break;
                }
            }
            return Flag;
        }
    }

}
