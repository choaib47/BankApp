using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Konto
    {
        private int kontonummer;
        private string inhaber;
        private decimal saldo = 0;

        public Konto (int kontonummer, string inhaber, int saldo)
        {
            this.kontonummer = kontonummer;
            this.inhaber = inhaber;
            this.saldo = saldo;
        }

        public void Einzahlen(decimal betrag)
        {
            saldo += betrag;
        }
        public void Abheben(decimal betrag)
        {
            saldo -= betrag;
        }

        public void ZeigeInfo()
        {
            Console.WriteLine($"{kontonummer}\n {inhaber}\n {saldo}");
        }
    }
}
