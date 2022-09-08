using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscreveReaisExtenso
{
    public class Resolve
    {
        public int valorEntrada;

        public Resolve(int valorEntrada)
        {
            this.valorEntrada = valorEntrada;
        }

        public string ResolveUnidades()
        {
            var totalUnidades = "";
            var unidades = new Valores(valorEntrada);
            totalUnidades = unidades.EscreveUnidades();

            return totalUnidades;
        }
        public string ResolveDezenas()
        {
            var stringChegada = valorEntrada.ToString();
            var totalDezena = "";

            if (valorEntrada < 10)
            {
                var operaUnidadeObj = new Resolve(valorEntrada);
                var operaUnidade = operaUnidadeObj.ResolveUnidades();
                totalDezena = operaUnidade;
            }

            else if (valorEntrada > 10 && valorEntrada < 20)
            {

                var operaDezena = new Valores(valorEntrada);
                totalDezena = operaDezena.EscreveDezenas();

            }
            else if (valorEntrada == 10 || valorEntrada >= 20)

            {
                if (valorEntrada % 10 == 0)
                {
                    var decimaisDezena = new Valores(valorEntrada);
                    var dezenaFechada = decimaisDezena.EscreveDezenas();
                    totalDezena = dezenaFechada;
                }
                else if (valorEntrada % 10 != 0)
                {
                    var stringDezena = valorEntrada.ToString();
                    var dezenaInt = Convert.ToInt32(stringDezena.Substring(0, 1)) * 10;
                    var dezenaParteUm = new Valores(dezenaInt);
                    var dezenaValor = dezenaParteUm.EscreveDezenas();

                    var unidadeInt = Convert.ToInt32(stringDezena.Substring(1, 1));
                    var dezenaParteDois = new Resolve(unidadeInt);
                    var unidadeValor = dezenaParteDois.ResolveUnidades();
                    totalDezena = dezenaValor + " e " + unidadeValor;

                }
            }
            return totalDezena;

        }

        public string ResolveCentenas()
        {
            var parteUmCentena = "";
            var parteDoisCentena = "";
            var totalCentena = "";
            var stringCentena = valorEntrada.ToString("000");

            if (valorEntrada % 100 == 0)
            {
                var qtdCentenas = new Valores(valorEntrada);
                parteUmCentena = qtdCentenas.EscreveCentenas();

                totalCentena = parteUmCentena;
            }

            else if (valorEntrada % 100 != 0)
            {
                if (valorEntrada > 100 && valorEntrada < 200)
                {
                    parteUmCentena = "Cento" + " e ";
                }
                else if (valorEntrada > 200)
                {
                    var casaCentena = Convert.ToInt16(stringCentena.Substring(0, 1)) * 100;
                    var qtdCentenas = new Valores(casaCentena);
                    parteUmCentena = qtdCentenas.EscreveCentenas() + " e ";
                }

                var casaDezena = Convert.ToInt32(stringCentena.Substring(1, 2));
                var dezenaCentena = new Resolve(casaDezena);
                if (casaDezena < 10)
                { parteDoisCentena = dezenaCentena.ResolveUnidades(); }
                else
                { parteDoisCentena = dezenaCentena.ResolveDezenas(); }

                totalCentena = parteUmCentena + parteDoisCentena;

            }
            
         return totalCentena;
        }
    }
}


