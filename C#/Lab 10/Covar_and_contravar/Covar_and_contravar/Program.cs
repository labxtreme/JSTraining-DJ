using System;

namespace Covar_and_contravar
{
    class Program
    {
        public delegate Animal DG(Dog d);

        static void Main(string[] args)
        {
            DG d1 = newDog;
            d1 += newAn;
            Dog d= new Dog();
            Animal c = new Animal();
            d1(d);


        }

        public static Dog newDog(Dog d)
        {
            d.Display_name();
            return d;
        }
        public static Animal newAn(Animal d)
        {
            d.Display_age();
            return new Dog();
        }
    }
}
