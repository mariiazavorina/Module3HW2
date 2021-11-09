﻿using ListPractise.Collections.Abstractions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListPractise.Collections
{
    public class CultureResolver : ICultureResolver
    {
        private readonly CultureInfo _defaultInfo;

        public CultureResolver()
        {
            _defaultInfo = CultureInfo.GetCultureInfo("en-Gb");
        }

        public CultureInfo GetCultureInfo(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name is null or empty");
            }

            if (Regex.IsMatch(name, "[A-Za-z]"))
            {
                return CultureInfo.GetCultureInfo("en-Gb");
            }
            else if (Regex.IsMatch(name, "[ЁёА-Яа-я]"))
            {
                return CultureInfo.GetCultureInfo("ru-Ru");
            }
            else
            {
                return _defaultInfo;
            }
        }
    }
}
