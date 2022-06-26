using System;
using System.Collections.Generic;
using System.Text;

namespace Neuron
{
    class Neuron
    {
        public List<double>[] weights;
        public List<double> inp_weights;
        public List<double>[] new_hid_layers;
        public double[] new_inp_layers;

        public void Study(string param)
        {
            Console.WriteLine("Здесь пока ничего нет");

        }
        public void Compile(string param)
        {

            for (int i = 0; i < new_hid_layers.Length; i++)
            {
                for (int i2 = 0; i2 < new_hid_layers[i].Count; i2++)
                {
                
                    for (int i3 = 0; i3 < weights[i+1].Count; i3++)
                    {
                        new_hid_layers[i][i2] += weights[i+1][i3] * new_hid_layers[i][i2];
                    }
                }
            }


        }
        
        public void Create(double[] inp_layers, List<double>[] hid_layers)
        {
            List<List<double>[]> weights = new List<List<double>[]>();
            inp_weights = new List<double>();
            List<double>[] h_lay_w = new List<double>[0];




            for (int i = 0; i < inp_layers.Length * hid_layers[0].Count; i++)
            {

                Random rand1 = new Random();
                double rand_int1 = rand1.NextDouble();
                inp_weights.Add(rand_int1);

            }
            
            for (int i2 = 1; i2 < hid_layers.Length; i2++)
            {
                h_lay_w = new List<double>[hid_layers[i2 + 1].Count];
                for (int i3 = 0; i3 < hid_layers[i2].Count; i3++)
                {
                    for (int i4 = 0; i4 < hid_layers[i2+1].Count; i4++)
                    {
                        Random rand2 = new Random();
                        double rand_int2 = rand2.NextDouble();
                        
                    }
                    

                }
                weights.Add(h_lay_w);
            }
            new_hid_layers = hid_layers;
            new_inp_layers = inp_layers;
        }
        public string return_weights()
        {
            string result = "";
            for (int i1 = 0; i1 < weights.Length; i1++)
            {

                for (int i2 = 0; i2 < weights[i1].Count; i2++)
                {
                    result = result + "[" + i1 + ", " + weights[i1][i2] + "]; ";
                }
            }
            return result+"   "+inp_weights.Count;
        }



    }
}
