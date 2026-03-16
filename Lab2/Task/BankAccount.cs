using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Task
{
    public class BankAccount
    {
        private double saldo;
        private string name;

        public BankAccount(string name, double saldo) { 
            this.name = name;
            this.saldo = saldo;
        }

        public void Wplata(double kwota){
            if (kwota < 0)
            {
                Console.WriteLine("Nie możesz podać ujemnej kwoty");
            }
            else {
                saldo += kwota;
            }
        }

        public void Wyplata(double kwota) {
            if ((saldo - kwota) < 0)
            {
                Console.WriteLine("Nie masz dostatecznie środków na koncie");
            }
            else {
                saldo -= kwota;
           
            
            }
        }

        public double Saldo { 
            get { return saldo; }
        }
    }
}
