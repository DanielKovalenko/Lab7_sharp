using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_adonet.Model
{
    public class Books
    {
        //Автор, назва, видавництво, рік видання

        public string Author { get; set; }
        public string Title { get; set; }
        public string Publishing { get; set; }
        public int Publication_year { get; set; }

        public Books(string author, string title, string publishing, int year)
        {
            Author = author;
            Title = title;
            Publishing = publishing;
            Publication_year = year;
        }
        public Books()
        {

        }
    }
}
