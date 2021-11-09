using ListPractise.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractise.Collections.Abstractions
{
    public interface IPhoneBook<T> where T : IContact
    {
        public void Add(T contact);
        public IReadOnlyCollection<T> this[string key] { get; }
    }
}
