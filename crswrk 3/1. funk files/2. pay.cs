using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crswrk_3
{
    internal class pay
    {
    }

    public class payment

    {
        public long card_number { get; set; }
        public DateOnly card_date { get; set; }
        public string card_name { get; set; }
        public int CVC { get; set; }
        public double sum {get; set; }

        public payment() 
        {
            sum = 0;
        }

        public payment(long c_num, DateOnly c_date, string c_name, int cvc)
        {
            sum = 0;
            card_number = c_num;
            card_date = c_date;
            card_name = c_name;
            CVC = cvc;
        }

        public payment AddDetails(payment pay, long c_num, DateOnly ex_date, string c_name, int cvc)
        {
            pay.card_number = c_num;
            pay.card_date = ex_date;
            pay.card_name = c_name;
            pay.CVC = cvc;
            return pay;
        }

        public string PayString(payment pay)
        {
            string st = "Card details:\n";
            if (pay.card_number == 0)
            {
                st += "You haven't linked card details yet!";
            }
            else
            {
                st += $"Summ: {pay.sum}\nCard number: {card_number}\nExpiry date: *** (protected)\n" +
                $"Cardholder's name: {card_name}\nCVC / CVV: *** (protected)\n\n";
                st += "If you want to change the card details, add a new card.\n";

            }
            return st;
        }

        public bool IfSumIsNull(payment pay)
        {
            bool result = false;
            if (pay.sum != 0)
            {
                result = true;
            }
            return result;
        }

        public bool IfCardNumberIsNull(payment pay)
        {
            bool result = false;
            if (pay.card_number != 0 || pay.card_name != null || pay.CVC != 0)
            {
                result = true;
            }
            return result;
        }

    }
}
