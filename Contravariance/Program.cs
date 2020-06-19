using System;
using System.Collections.Generic;

namespace Contravariance
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleExample();
            //SortingWithInterface();
            SortingWithDelegate();
        }

        private static void SimpleExample()
        {
            ICovariant<Apple> covariantApples = new Covariant<Apple>();

            ICovariant<Fruit> covariantFruit = covariantApples;

            IContravariant<Fruit> contravariantFruit = new Contravariant<Fruit>();

            IContravariant<Apple> contravariantApples = contravariantFruit;
        }

        private static void SortingWithInterface()
        {
            List<Apple> apples = new List<Apple> 
            {
                new Apple {Name = "Granny Smith", Weight = 80, ForEating = true },
                new Apple {Name = "Arthur Turner", Weight = 70, ForEating = false },
                new Apple {Name = "Honeygold", Weight = 80, ForEating = true },
                new Apple {Name = "Kerry Pippin", Weight = 82, ForEating = true },
                new Apple {Name = "Newton Wonder", Weight = 75, ForEating = false }
            };

            foreach (var apple in apples)
                Console.WriteLine(apple);

            Console.WriteLine();

            Sort(apples, new FruitComparer());

            foreach (var apple in apples)
                Console.WriteLine(apple);
        }

        private static void Sort(List<Apple> collection, IMyComparer<Apple> comparer)
        {
            collection.Sort(new ComparerAdapter<Apple>(comparer));
        }

        private static void SortingWithDelegate()
        {
            List<Apple> apples = new List<Apple>
            {
                new Apple {Name = "Granny Smith", Weight = 80, ForEating = true },
                new Apple {Name = "Arthur Turner", Weight = 70, ForEating = false },
                new Apple {Name = "Honeygold", Weight = 80, ForEating = true },
                new Apple {Name = "Kerry Pippin", Weight = 82, ForEating = true },
                new Apple {Name = "Newton Wonder", Weight = 75, ForEating = false }
            };

            foreach (var apple in apples)
                Console.WriteLine(apple);

            Console.WriteLine();

            SortingDelegate<Fruit> sorter = (l, r) => (int)(l.Weight - r.Weight);

            Sort(apples, sorter);

            foreach (var apple in apples)
                Console.WriteLine(apple);
        }

        private static void Sort(List<Apple> collection, SortingDelegate<Apple> sorter)
        {
            collection.Sort((l,r) => sorter(l,r));
        }
    }
}
