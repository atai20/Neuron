using System;
using System.Collections.Generic;
namespace Neuron
{
    class Program
    {
        static void Main(string[] args)
        {
            Neuron ax = new Neuron();

            double[] input = new double[3] { 0.2, 0.4, 0.2 };
            double[] expect = new double[2] { 0.26, 0.5 };

            List<double>[] hidden_layers = new List<double>[4] { new List<double> { 0.01, 0.11, 0.2 }, new List<double> { 0.1, 0.2, 0.3 }, new List<double> { 0.4, 0.5 }, new List<double> { 0.6, 0.7 } };


            ax.Create(hidden_layers);
            Console.WriteLine(ax.return_weights());
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            ax.Compile();
            ax.Study(expect);



        }
    }
}
