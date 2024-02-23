using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GrafickaKalkulackaUkol
{
    internal class kalkulacka
    {
        public double vysledek;
        
        
        public double Soucet(double vysledek, double cislo2)
        {
            return vysledek + cislo2;
        }

        public double Rozdil(double vysledek, double cislo2)
        {
            return vysledek - cislo2;
        }

        public double Soucin(double vysledek, double cislo2)
        {
            return vysledek * cislo2;
        }

        public double Podil(double vysledek, double cislo2)
        {
            return vysledek / cislo2;
        }

        public double ProvedVypocet(string znamenko, double cislo2)
        {

            switch (znamenko)
            {
                case "+":
                    vysledek = Soucet(vysledek, cislo2);
                    break;
                case "-":
                    vysledek = Rozdil(vysledek, cislo2);                   
                    break;
                case "*":
                    vysledek = Soucin(vysledek, cislo2);                    
                    break;
                case "/":
                    vysledek = Podil(vysledek, cislo2);
                    break;
                default:                   
                    break;                                 
            }
            return vysledek;
        }
        
    }
}
