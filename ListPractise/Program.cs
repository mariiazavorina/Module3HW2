using ListPractise.Collections;
using ListPractise.Models;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ListPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneBook<Contact>();
            phoneBook.Add(new Contact() { Name = "Igor", LastName = "Serduik" });
            phoneBook.Add(new Contact() { Name = "Igor", LastName = "Bobro" });
            phoneBook.Add(new Contact() { Name = "Ilya", LastName = "Добродушный" });

            var x = phoneBook["Ig"];
        }
    }
}
