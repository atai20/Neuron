using System;
using System.Collections.Generic;
using System.Text;

namespace Neuron
{
    class Neuron
    {
        List<List<double>[]> weights = new List<List<double>[]>();
        public List<double>[] hid_layers;


        public void Study(double[] expect, double rate)
        {
            for (int i1 = weights.Count - 1; i1 == 0; i1--)
            {

                for (int i2 = 0; i2 < weights[i1 - 1].Length; i2++)
                {

                    hid_layers[i1 - 1][i2] = 0;

                    for (int i3 = 0; i3 < weights[i1 - 1][i2].Count; i3++)
                    {
                        double[] error = expect;

                        for (int i4 = weights.Count - 1; i4 == 0; i4--)
                        {
                            double weights_delta = error[i4] * hid_layers[i1][i3];
                            weights[i1][i2][i3] -= weights_delta * rate;
                        }

                        hid_layers[i1 - 1][i2] += hid_layers[i1][i3] * weights[i1][i2][i3];

                    }

                }

            }
        }
        public void Compile()
        {

            for (int i1 = 1; i1 <= weights.Count; i1++)
            {

                for (int i2 = 0; i2 < weights[i1 - 1].Length; i2++)
                {

                    for (int i3 = 0; i3 < weights[i1 - 1][i2].Count; i3++)
                    {
                        hid_layers[i1][i3] = 0;
                    }
                    for (int i3 = 0; i3 < weights[i1 - 1][i2].Count; i3++)
                    {

                        hid_layers[i1][i3] += hid_layers[i1 - 1][i2] * weights[i1 - 1][i2][i3];

                    }

                }

            }


        }

        public void Create(List<double>[] pl_hid_layers)
        {

            hid_layers = pl_hid_layers;

            for (int i2 = 0; i2 < hid_layers.Length; i2++)
            {

                if (i2 <= hid_layers[i2].Count)
                {
                    List<double>[] h_lay_w = new List<double>[hid_layers[i2].Count];
                    for (int i3 = 0; i3 < hid_layers[i2].Count; i3++)
                    {
                        List<double> h_lay_w_in = new List<double>();
                        for (int i4 = 0; i4 < hid_layers[i2 + 1].Count; i4++)
                        {
                            Random rand2 = new Random();
                            double rand_int2 = rand2.NextDouble();
                            h_lay_w_in.Add(rand_int2);
                        }
                        h_lay_w[i3] = h_lay_w_in;


                    }
                    weights.Add(h_lay_w);
                }
            }


        }
        public string return_weights()
        {
            string result = "";
            for (int i1 = 0; i1 < weights.Count; i1++)
            {
                result = result + "[ " + i1 + "; ";
                for (int i2 = 0; i2 < weights[i1].Length; i2++)
                {
                    result = result + "[ " + i2 + "; ";
                    for (int i3 = 0; i3 < weights[i1][i2].Count; i3++)
                    {
                        result = result + " " + weights[i1][i2][i3] + "; ";
                    }
                    result = result + " ]; ";
                }
                result = result + "]; ";
            }
            return result + "   " + weights.Count;
        }



    }
}
