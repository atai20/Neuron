using System;
using System.Collections.Generic;
namespace Neuron
{
    class Program
    {
        static void Main(string[] args)
        {
            Neuron ax = new Neuron();

            double[] input = new double[3] {2, 2, 3};
            List<double>[] hidden_layers = new List<double>[3] { new List<double>{ 0.2, 0.2 }, new List<double> { 0.2, 0.2 }, new List<double> { 0.2, 0.2 } };
            

            ax.Create(input, hidden_layers);
            ax.Study("sigm");
            Console.WriteLine(ax.return_weights());
        }
    }
}
