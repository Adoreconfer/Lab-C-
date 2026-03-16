using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Task
{
    public class Sumator
    {
        private double[] Liczby;
  
        public Sumator(double[] Liczby) { 
            this.Liczby = Liczby;
        }

        public double Suma()
        {
            double sum = 0;
            foreach (var item in Liczby)
            {
                sum += item;
            }
            return sum;
        }

        public double SumaPodziel2()
        {
            double sum = 0;
            foreach (var item in Liczby)
            {
                if (item % 2 == 0) {
                    sum += item;
                }
            }
            return sum;
        }

        public int IleElementów() { 
            return Liczby.Length;
        }

        public void view()
        {
            foreach (var item in Liczby)
            {
                Console.Write(item + " ");
            }
        }

        public void printRange(int lowIndex, int highIndex) {
            if (lowIndex < 0) { 
                lowIndex = 0;
            }
            if (highIndex > Liczby.Length - 1)
            {
                highIndex = Liczby.Length - 1;
            }
            for (int i = lowIndex; i <= highIndex; i++) {
                Console.Write(Liczby[i] + " ");
            }
        }
    }
}
