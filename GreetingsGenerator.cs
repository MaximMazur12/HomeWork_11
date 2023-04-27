using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_Ninject
{
    internal class GreetingsGenerator : IGreetingsGenerator
    {
        private string[] greetings = new string[] { "Hello ", "Hi ", "Hey ", "Good morning ", "good evening " };
     
        public string GetRandomGreeting()
        {
            return greetings[new Random().Next(0, greetings.Length)];
        }
    }
}
