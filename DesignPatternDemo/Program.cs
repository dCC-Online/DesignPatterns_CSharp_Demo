using DesignPatternDemo.CompositePattern;
using DesignPatternDemo.DecoratorPattern;
using DesignPatternDemo.DependencyInjection;
using DesignPatternDemo.FactoryPattern;
using DesignPatternDemo.ObserverPattern;
using DesignPatternDemo.ProxyPattern;
using DesignPatternDemo.FacadePattern;
using DesignPatternDemo.DependencyInjection.AnotherExample;
using System.Net;
using System.Net.Sockets;
using System.Text;
using DesignPatternDemo.SingletonPattern;

namespace DesignPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Factory Pattern ////

            FordFiestaFactory factory = new FordFiestaFactory();
            Car whiteFiesta = factory.CreateACar("White");
            Car blackFiesta = factory.CreateACar("Black");
            Console.WriteLine("Make: {0} \nModel: {1} \nColor: {2}", whiteFiesta.Make, whiteFiesta.Model, whiteFiesta.Color);
            Console.ReadLine();

            //// Observer Pattern ////

            //YouTubeChannel devCodeCampChannel = new YouTubeChannel();

            //ISubscriber Vega = new User("Vega");
            //ISubscriber Stoffels = new User("Stoffels");
            //ISubscriber LaGrange = new Moderator("LaGrange");

            //devCodeCampChannel.Subscribe(Vega);
            //devCodeCampChannel.Subscribe(Stoffels);
            //devCodeCampChannel.Subscribe(LaGrange);
            //devCodeCampChannel.Upload();

            //devCodeCampChannel.Unsubscribe(Vega);
            //devCodeCampChannel.Upload();
            //Console.ReadKey();

            ////Facade Pattern ////
            //PizzaFacade organizedRestaurant = new PizzaFacade("BBQ", "Onions", "Gouda");
            //organizedRestaurant.MakePizza();


            //Dough dough = new Dough();
            //Sauce sauce = new Sauce("Tomato");
            //FacadePattern.Topping greenPepper = new FacadePattern.Topping("Green Peppers");
            //Cheese mozzarella = new Cheese("Mozzarella");
            //Oven oven = new Oven();

            //PizzaFacade unorganizedRestaurant = new PizzaFacade("Tomato", "Green Peppers", "Mozzarella");
            //dough.AddSauce(sauce);
            //dough.AddCheese(mozzarella);
            //dough.AddTopping(greenPepper);
            //oven.SetTemperature(425);
            //oven.SetTimer(20);
            //oven.Cook(dough);

            //Console.ReadLine();

            //// Composite Pattern ////

            //Worker Matt = new Worker("Matt", "Worker", 80);
            //Supervisor Angela = new Supervisor("Angela", "CFO", 90);
            //Supervisor Laurie = new Supervisor("Laurie", "CEO", 100);
            //Supervisor Sydney = new Supervisor("Sydney", "Head of Marketing", 90);
            //Worker Gail = new Worker("Gail", "Worker", 85);

            //Angela.AddEmployee(Matt); //Matt works for Angela
            //Laurie.AddEmployee(Angela); //Angela works for Laurie
            //Laurie.AddEmployee(Sydney); //Sydney works for Laurie
            //Sydney.AddEmployee(Gail); //Gail works for Sydney

            //Laurie.DisplayStatus();
            //Console.ReadLine();

            //// Dependency Injection ////

            //DeepDish deepDish = new DeepDish();
            //StuffedCrust stuffedCrust = new StuffedCrust();
            //ThinCrust thin = new ThinCrust();

            //Pizzeria pizzeria = new Pizzeria(stuffedCrust);
            //pizzeria.AddFood();
            //pizzeria.PrepareFood();

            //PowerSupply electric = new PowerSupply(10);
            //CoffeeMaker coffeeMaker = new CoffeeMaker(electric);
            //coffeeMaker.Use();

            //// Proxy Pattern ////

            //ComponentPriceProxy componentPriceProxy = new ComponentPriceProxy();
            //componentPriceProxy.RunProxy();

            ////Server Software of Proxy Pattern
            //var ip = IPAddress.Parse("127.0.0.1");
            //var listener = new TcpListener(ip, 8080);

            //while (true)
            //{
            //    listener.Start();
            //    Console.WriteLine("Waiting for a connection...");

            //    using (var socket = listener.AcceptSocket())
            //    {
            //        Console.WriteLine("Client Connected.");

            //        var data = new byte[15];
            //        socket.Receive(data);
            //        var input = Encoding.Default.GetString(data).TrimEnd('\0');
            //        Console.WriteLine("Clinet Requested: {0}", input);

            //        var prices = new StoredComponentPrices();
            //        var price = 0m;

            //        switch (input)
            //        {
            //            case "cpu":
            //                price = prices.CpuPrice;
            //                break;
            //            case "ram":
            //                price = prices.RamPrice;
            //                break;
            //            case "ssd":
            //                price = prices.SsdPrice;
            //                break;
            //        }
            //        var responseValue = Convert.ToString(price);
            //        var response = Encoding.Default.GetBytes(responseValue);

            //        socket.Send(response);
            //        Console.WriteLine("Response sent to Client: {0}", responseValue);
            //        Console.WriteLine("");
            //    }

            //    listener.Stop();
            //}

            //// Decorator Pattern ////
            //IceCream chocolateIceCream = new Chocolate();
            //chocolateIceCream = new Sprinkle(chocolateIceCream);
            //chocolateIceCream = new Fudge(chocolateIceCream);

            //Console.WriteLine(chocolateIceCream.Cost());
            //Console.ReadKey();


            //// Singleton Pattern ////
            Country us = new Country("USA");
            Country canada = new Country("Canada");

            us.counter.Increment();
            us.counter.Increment();

            Console.WriteLine(canada.counter.Count);
        }
    }
}