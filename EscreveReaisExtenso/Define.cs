using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace EscreveReaisExtenso
{
    public class Define
    {
        public string Entrada { get; set; }

        public string DefineMilhao(string entrada)
        {
            var parteMilhao = Convert.ToInt32(entrada.Substring(entrada.Length - 11, 3));
            var parteMilhar = Convert.ToInt32(entrada.Substring(entrada.Length - 8, 3));
            var parteRestante = Convert.ToInt32(entrada.Substring(entrada.Length - 8, 6));
            var parteCentena = Convert.ToInt32(entrada.Substring(entrada.Length - 5, 3));
            var milhaoFinal = "";
            var grandezaUm = "";
            if (parteMilhao != 0)
            {
                var unidadeMilhao = new Resolve(parteMilhao);
                milhaoFinal = unidadeMilhao.ResolveCentenas();

                if (parteMilhao == 1)
                {
                    if (parteRestante != 0)
                    {
                        if (parteMilhar == 0)
                        {
                            if (parteCentena <= 99)
                            { grandezaUm = " milhao e "; }
                            else if (parteCentena > 99)
                            { grandezaUm = " milhao, "; }
                        }
                        else
                        { grandezaUm = " milhao, "; }
                        //acho que n vale alterar if (parteMilhar == 0 && parteCentena <= 99)
                        //{ grandezaUm = " milhao e "; }
                        //else if (parteMilhar == 0 && parteCentena > 99)
                        //{ grandezaUm = " milhao, "; }
                        //}
                    }
                    else
                    {
                        grandezaUm = " milhao de";
                    }
                }
                else if (parteMilhao > 1)
                {
                    if (parteRestante != 0)
                    {
                        if (parteMilhar == 0)
                        {
                            if (parteCentena <= 99)
                            { grandezaUm = " milhoes e "; }
                            else if (parteCentena > 99)
                            { grandezaUm = " milhoes, "; }
                        }
                        else
                        { grandezaUm = " milhoes, "; }
                        //acho que n vale alterar if (parteMilhar == 0 && parteCentena <= 99)
                        //{ grandezaUm = " milhoes e "; }
                        //else if (parteMilhar == 0 && parteCentena > 99)
                        //{ grandezaUm = " milhoes, "; }
                        //}
                    }
                    else
                    {
                        grandezaUm = " milhoes de";
                    }
                }
            }
            var milhaoExtenso = milhaoFinal + grandezaUm;
            return milhaoExtenso;
        }
        public string DefineMilhar(string entrada)
        {
            var parteMilhar = Convert.ToInt32(entrada.Substring(entrada.Length - 8, 3));
            var parteCentena = Convert.ToInt32(entrada.Substring(entrada.Length - 5, 3));
            var grandezaDois = "";
            var milharFinal = "";
            if (parteMilhar != 0)
            {
                var centenaMilhar = new Resolve(parteMilhar);
                milharFinal = centenaMilhar.ResolveCentenas();
            }

            if (parteMilhar != 0)
            {
                if (parteCentena != 0)
                {
                    if (parteCentena > 99)
                    { grandezaDois = " mil, "; }
                    else if (parteCentena <= 99)
                    { grandezaDois = " mil e "; }
                }
                else
                { grandezaDois = " mil"; }
            }
            var milharExtenso = milharFinal + grandezaDois;
            return milharExtenso;


        }
        public string DefineCentena(string entrada)
        {
            var parteCentena = Convert.ToInt32(entrada.Substring(entrada.Length - 5, 3));
            var centenaFinal = "";
            if (parteCentena != 0)
            {
                if (parteCentena < 100)
                {
                    var centena = new Resolve(parteCentena);
                    centenaFinal = centena.ResolveDezenas();
                }
                else
                {
                    var centena = new Resolve(parteCentena);
                    centenaFinal = centena.ResolveCentenas();
                }
            }
            return centenaFinal;
        }

        public string DefineCentavo(string entrada)
        {
            var parteCentavo = Convert.ToInt32(entrada.Substring(entrada.Length - 2, 2));
            var centavoFinal = "";
            if (parteCentavo != 0)
            {
                if (parteCentavo < 10)
                {
                    var centavo = new Resolve(parteCentavo);
                    centavoFinal = centavo.ResolveUnidades();
                }
                else
                {
                    var centavo = new Resolve(parteCentavo);
                    centavoFinal = centavo.ResolveDezenas();
                }
            }
            return centavoFinal;
        }

        public  string DefineMoeda(string entrada)
        {
            var cifrao = "";
            var chegadaInt = Convert.ToInt64(Entrada);
            var parteMilhao = Convert.ToInt32(entrada.Substring(entrada.Length - 11, 3));
            var parteMilhar = Convert.ToInt32(entrada.Substring(entrada.Length - 8, 3));
            var parteCentena = Convert.ToInt32(entrada.Substring(entrada.Length - 5, 3));

            if (chegadaInt > 99)
            {
                if (parteMilhao == 0 && parteMilhar == 0 && parteCentena == 1)
                { cifrao = " real "; }
                else
                { cifrao = " reais "; }
            }
            return cifrao;
        }

        public string TemConectivo(string entrada)
        {
            var parteMilhao = Convert.ToInt32(entrada.Substring(entrada.Length - 11, 3));
            var parteMilhar = Convert.ToInt32(entrada.Substring(entrada.Length - 8, 3));
            var parteCentena = Convert.ToInt32(entrada.Substring(entrada.Length - 5, 3));
            var parteCentavo = Convert.ToInt32(entrada.Substring(entrada.Length - 2, 2));
            var conectivo = "";
            if ((parteMilhao > 0 || parteMilhar > 0 || parteCentena > 0) && parteCentavo > 0)
            { conectivo = "e "; }
            return conectivo;
        }

        public string TemDecimal(string entrada)
        {
            var parteCentavo = Convert.ToInt32(entrada.Substring(entrada.Length - 2, 2));
            var valorDecimal = "";
            if (parteCentavo != 0)
            {
                if (parteCentavo == 1)
                { valorDecimal = " centavo"; }
                else
                { valorDecimal = " centavos"; }
            }
            return valorDecimal;
        }

        public  string EscreveExtenso(string entrada)
        {
            return  DefineMilhao(Entrada) + DefineMilhar(Entrada) + DefineCentena(Entrada) + DefineMoeda(Entrada) + DefineCentavo(Entrada) + TemConectivo(Entrada) + DefineCentavo(Entrada);
        }





    }
}*/