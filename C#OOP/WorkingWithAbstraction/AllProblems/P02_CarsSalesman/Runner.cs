﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem02CarsSalesman
{
    public class Runner
    {
        public static void Run()
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int engineCount = int.Parse(Console.ReadLine());
            CreateEngine(engines, engineCount);

            int carCount = int.Parse(Console.ReadLine());
            CreateCar(cars, engines, carCount);

            Console.WriteLine(PrintCars(cars));
        }

        private static void CreateCar(List<Car> cars, List<Engine> engines, int carCount)
        {
            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                string engineModel = parameters[1];

                Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

                int weight = -1;

                if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
                {
                    cars.Add(new Car(model, engine, weight));
                }
                else if (parameters.Length == 3)
                {
                    string color = parameters[2];
                    cars.Add(new Car(model, engine, color));
                }
                else if (parameters.Length == 4)
                {
                    string color = parameters[3];
                    cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
                }
                else
                {
                    cars.Add(new Car(model, engine));
                }
            }
        }

        private static void CreateEngine(List<Engine> engines, int engineCount)
        {
            for (int i = 0; i < engineCount; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];
                int power = int.Parse(parameters[1]);

                int displacement = -1;

                if (parameters.Length == 3 && int.TryParse(parameters[2], out displacement))
                {
                    engines.Add(new Engine(model, power, displacement));
                }
                else if (parameters.Length == 3)
                {
                    string efficiency = parameters[2];
                    engines.Add(new Engine(model, power, efficiency));
                }
                else if (parameters.Length == 4)
                {
                    string efficiency = parameters[3];
                    engines.Add(new Engine(model, power, int.Parse(parameters[2]), efficiency));
                }
                else
                {
                    engines.Add(new Engine(model, power));
                }
            }
        }

        public static string PrintCars(List<Car> cars)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var car in cars)
            {
                sb.AppendLine(car.ToString());
            }

            string stringToReturn = sb.ToString().TrimEnd();

            return stringToReturn;
        }
    }
}
