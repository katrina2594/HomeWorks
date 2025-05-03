using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_1
{
    public class Book<T, U>
    {
        public T Code { get; set; }
        public U PublicationYear { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public Book(string title,string author,U publicationYear, T code)
        {
            Code = code;
            PublicationYear = publicationYear;
            Author = author;
            Title = title;
        }
        public override string ToString()
        {
            return $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
        }


    }
}
