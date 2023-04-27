using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW11_Ninject;

    public class DateTimeGenerator : IDateTimeGenerator
{
        public string GetCurrentDateTime()
        {
            return DateTime.Now.ToString();
        }

        public string GetRandomDateTime()
        {
            return DateTime.Now.AddDays(new Random().Next(0, 365)).ToString();
        }
    }

