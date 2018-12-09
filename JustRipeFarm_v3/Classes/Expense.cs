using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    class Expense
    {
        private int id;
        private decimal amount;
        private DateTime date;
        private string payee;
        private string category;
        private string description;

        public int Id { get => id; set => id = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Payee { get => payee; set => payee = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
    }
}
