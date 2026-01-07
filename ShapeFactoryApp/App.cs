using ShapeFactoryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactoryApp
{
    public class App
    {
        public List<ShapeFactory> Factories { get; private set; }

        public App()
        {
            Factories = new List<ShapeFactory>();
        }

        public void RegisterFactory<T>() where T : ShapeFactory, new()
        {
            Factories.Add(new T());
        }

        public void Run()
        {
            while (true)
            {
                ShowMenuOptions();
                var input = Console.ReadLine();

                if (int.TryParse(input, out var choice))
                {
                    if (choice == 0)
                    {
                        Console.WriteLine("Quitting App!");
                        break;
                    }

                    if (choice <= Factories.Count)
                    {
                        HandleInput(choice);
                    }
                    else
                    {
                        Console.WriteLine("Invalid option selected, please try again!");
                    }
                }
            }
        }

        public void ShowMenuOptions()
        {
            Console.WriteLine("Choose a shape to create:");
            for (int i = 0; i < Factories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Factories[i].GetShapeName()}");
            }
            Console.WriteLine("0. Exit");
        }

        public void HandleInput(int choice)
        {
            var factory = Factories[choice - 1];
            var shape = factory.Create();

            Console.WriteLine("Shape Type: " + shape.GetType().Name);
            Console.WriteLine("Area: " + shape.CalculateArea());
            Console.WriteLine("Perimeter: " + shape.CaluclatePerimiter());
            shape.Draw();
        }

        public void EnumerateRegisteredFactories()
        {
            foreach (var factory in Factories)
            {
                Console.WriteLine(factory.GetType().Name);
            }
        }
    }
}
