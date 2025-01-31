using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crswrk_3
{
    internal class intrfc
    {
    }

    public enum excursion
    {
        museum,
        art_gallery,
        hiking,
        gastronomic_tour,
        city_tour,
        swimming,
        skiing
    }

    interface IClient
    {
        string name { get; set; }
        DateOnly birth_date { get; set; }
        int pass_s { get; set; }
        int pass_n { get; set; }
        DateOnly pass_date { get; set; }
        string pass_given { get; set; }

    }

    interface IPoint
    {
        string point_name { get; set; }
        int point_days { get; set; }
        string hotel_name { get; set; }
        int hotel_stars {  get; set; }

        excursion exc { get; set; }
    }

    interface IManager
    {
        string name { get; set; }
        int password { get; set; }
    }
}
