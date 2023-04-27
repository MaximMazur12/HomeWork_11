using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_Ninject
{
    internal class NamesGenerator : INamesGenerator
    {
        private string[] names = { "Ann  ", "Max  ", "Artem  ","Dmytro  ", "Sergiy  " };
   

        public string GetRandomName()
        {
            return names[new Random().Next(0, names.Length)];
        }
    }
}
