using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscreveReaisExtenso
{
    public class Valores
    {
        public int Entrada { get; set; }

        public Valores(int entrada)
        {
            Entrada = entrada;
        }

        public string EscreveUnidades()
        {
            var compoeValor = "";
            switch (Entrada)
            {
                case 01:
                    compoeValor = "um";
                    break;
                case 02:
                    compoeValor = "dois";
                    break;
                case 03:
                    compoeValor = "tres";
                    break;
                case 04:
                    compoeValor = "quatro";
                    break;
                case 05:
                    compoeValor = "cinco";
                    break;
                case 06:
                    compoeValor = "seis";
                    break;
                case 07:
                    compoeValor = "sete";
                    break;
                case 08:
                    compoeValor = "oito";
                    break;
                case 9:
                    compoeValor = "nove";
                    break;
            }
            return compoeValor;
        }
        public string EscreveDezenas()
        {
            var compoeValor = "";
            switch (Entrada)
            {
                case 10:
                    compoeValor = "dez";
                    break;
                case 11:
                    compoeValor = "onze";
                    break;
                case 12:
                    compoeValor = "doze";
                    break;
                case 13:
                    compoeValor = "treze";
                    break;
                case 14:
                    compoeValor = "quatorze";
                    break;
                case 15:
                    compoeValor = "quinze";
                    break;
                case 16:
                    compoeValor = "dezesseis";
                    break;
                case 17:
                    compoeValor = "dezessete";
                    break;
                case 18:
                    compoeValor = "dezoito";
                    break;
                case 19:
                    compoeValor = "dezenove";
                    break;
                case 20:
                    compoeValor = "vinte";
                    break;
                case 30:
                    compoeValor = "trinta";
                    break;
                case 40:
                    compoeValor = "quarenta";
                    break;
                case 50:
                    compoeValor = "cinquenta";
                    break;
                case 60:
                    compoeValor = "sessenta";
                    break;
                case 70:
                    compoeValor = "setenta";
                    break;
                case 80:
                    compoeValor = "oitenta";
                    break;
                case 90:
                    compoeValor = "noventa";
                    break;
            }
            return compoeValor;
        }

        public string EscreveCentenas()
        {
            var compoeValor = "";
            switch (Entrada)
            {
                case 100:
                    compoeValor = "cem";
                    break ;
                case 200:
                    compoeValor = "duzentos";
                    break;
                case 300:
                    compoeValor = "trezentos";
                    break;
                case 400:
                    compoeValor = "quatrocentos";
                    break;
                case 500:
                    compoeValor = "quinhentos";
                    break;
                case 600:
                    compoeValor = "seiscentos";
                    break;
                case 700:
                    compoeValor = "setecentos";
                    break;
                case 800:
                    compoeValor = "oitocentos";
                    break;
                case 900:
                    compoeValor = "novecentos";
                    break;

            }
            return compoeValor;
        }
    }
}
