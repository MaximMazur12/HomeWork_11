using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_Ninject
{
    internal class RandomMessageBuilder
    {
        private readonly IDateTimeGenerator dateTimeGenerator;
        private readonly IGreetingsGenerator greetingsGenerator;
        private readonly INamesGenerator namesGenerator;
        private string message;

        public RandomMessageBuilder(IDateTimeGenerator dateTimeGenerator, IGreetingsGenerator greetingsGenerator, INamesGenerator namesGenerator)
        {
            this.dateTimeGenerator = dateTimeGenerator;
            this.greetingsGenerator = greetingsGenerator;
            this.namesGenerator = namesGenerator;
            message = "";
        }

        public RandomMessageBuilder AddDateTime(bool isRandom)
        {
            if (isRandom)
            {
                message += dateTimeGenerator.GetRandomDateTime();
            }
            else
            {
                message += dateTimeGenerator.GetCurrentDateTime();
            }
            return this;
        }

        public RandomMessageBuilder AddGreeting()
        {
            message += greetingsGenerator.GetRandomGreeting();
            return this;
        }

        public RandomMessageBuilder AddName()
        {
            message += namesGenerator.GetRandomName();
            return this;
        }

        public string Result()
        {
            return message;
        }
    }
}
