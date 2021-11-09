using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractise.Collections.Abstractions
{
    public interface ICultureResolver
    {
        public CultureInfo GetCultureInfo(string name);
    }
}
