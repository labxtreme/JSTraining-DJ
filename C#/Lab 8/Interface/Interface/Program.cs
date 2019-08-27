using System;
using Microsoft.Extensions.DependencyInjection;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = Confser();
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<Myapp>().Run();
            Console.ReadKey(true);

        }

        private static IServiceCollection Confser()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ICRUD, CRUDORACLE>();
            services.AddTransient<Myapp>();
            return services;
        }
    }
    public class Myapp
    {
        private readonly ICRUD _ob1;
        public Myapp(ICRUD a)
        {
            _ob1 = a;
        }

        public void Run()
        {
            Console.WriteLine(_ob1.get_name());
            Console.WriteLine(_ob1.get_price());
        }
    }
}
