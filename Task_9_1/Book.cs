using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_1
{
    class Book
    {
        private string _title;
        private string _author;
        public int Year { get; set; }
        public int Pages { get; set; }
        public Book(string title, string author, int year, int pages)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }
        public string GetInfo()
        {
            return $"{_title}, {_author}, {Year}, {Pages} стр.";
        }
    }
}
