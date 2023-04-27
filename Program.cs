using Ninject;
using HW11_Ninject;
{
    var module = new StandardKernel();
    module.Bind<IDateTimeGenerator>().To<DateTimeGenerator>();
    module.Bind<IGreetingsGenerator>().To<GreetingsGenerator>();
    module.Bind<INamesGenerator>().To<NamesGenerator>();

    var finish = module.Get<RandomMessageBuilder>();
    finish.AddGreeting();
    finish.AddName();
    finish.AddDateTime(true);
    Console.WriteLine(finish.Result());
}