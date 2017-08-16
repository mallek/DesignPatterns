using System;

namespace DesignPatterns
{
    public static class Driver
    {
        public static void Do()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var bf = new ProductFilter();
            WriteLine("Green products (new):");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
                WriteLine($" - {p.Name} is green");

            WriteLine("Large products");
            foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
                WriteLine($" - {p.Name} is large");

            WriteLine("Large blue items");
            foreach (var p in bf.Filter(products,
              new OrSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Large)))
            )
            {
                WriteLine($" - {p.Name} is big or blue");
            }
        }

        private static void WriteLine(string v)
        {
            Console.WriteLine(v);
        }
    }
}