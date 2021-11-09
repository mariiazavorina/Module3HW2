using ListPractise.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractise.Models
{
    public class Contact : IContact
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
