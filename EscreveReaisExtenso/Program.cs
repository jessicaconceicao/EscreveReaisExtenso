//Dada uma entrada em reais [00,00] (de um centavo até centenas de milhões), escreva-a por extenso.
using EscreveReaisExtenso;
using System.Text.RegularExpressions;

Console.WriteLine("Digite um valor [R$00,00]");
var numero = Console.ReadLine();
var stringChegada = Regex.Replace(numero, "['r','R','$','.',',']", "");
if(long.TryParse(stringChegada, out long chegadaInt) == false || stringChegada.Length < 4 || chegadaInt == 0 || chegadaInt > 99999999999)
{ 
    Console.WriteLine("Digite uma entra válida entre R$ 00,01 e R$ 999.999.999,99");
    return;
}

var stringEntrada = chegadaInt.ToString("00000000000");


var parteMilhao = Convert.ToInt32(stringEntrada.Substring(stringEntrada.Length - 11, 3));
var parteRestante = Convert.ToInt32(stringEntrada.Substring(stringEntrada.Length - 8, 6));
var parteMilhar = Convert.ToInt32(stringEntrada.Substring(stringEntrada.Length - 8, 3));
var parteCentena = Convert.ToInt32(stringEntrada.Substring(stringEntrada.Length - 5, 3));
var parteCentavo = Convert.ToInt32(stringEntrada.Substring(stringEntrada.Length - 2, 2));

var milhaoFinal = "";
var milharFinal = "";
var centenaFinal = "";
var centavoFinal = "";

if (parteMilhao != 0)
{
    var unidadeMilhao = new Resolve(parteMilhao);
    milhaoFinal = unidadeMilhao.ResolveCentenas();
}
if (parteMilhar != 0)
{
    var centenaMilhar = new Resolve(parteMilhar);
    milharFinal = centenaMilhar.ResolveCentenas();
}
if (parteCentena != 0)
{
    if(parteCentena < 100)
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

var grandezaUm = "";
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
            { grandezaUm = " milhões e "; }
            else if (parteCentena > 99)
            { grandezaUm = " milhões, "; }
        }
        else
        { grandezaUm = " milhões, "; }
    }
    else
    {
        grandezaUm = " milhões de";
    }
}
var grandezaDois = "";
if (parteMilhar != 0)
{
    if (parteCentena != 0)
    {
        if (parteCentavo != 0)
        {
            if (parteCentena > 99)
            { grandezaDois = " mil, "; }
            else if (parteCentena <= 99)
            { grandezaDois = " mil e "; }
        }
        else
        {
            grandezaDois = " mil e "; 
        }
    }
    else
    { grandezaDois = " mil"; }
}



var cifrao = "";
if (chegadaInt > 99)
{
    if (parteMilhao == 0 && parteMilhar == 0 && parteCentena == 1)
    { cifrao = " real "; }
    else
    { cifrao = " reais "; }
}

var centavos = "";
if ((parteMilhao > 0 || parteMilhar > 0 || parteCentena > 0) && parteCentavo > 0)
{ centavos = "e "; }

var moedas = "";
if (parteCentavo != 0)
{
    if (parteCentavo == 1)
    { moedas = " centavo"; }
    else
    { moedas = " centavos"; }
}

var milhaoExtenso = milhaoFinal + grandezaUm;
var milharExtenso = milharFinal + grandezaDois;

var valorExtenso = milhaoExtenso + milharExtenso + centenaFinal + cifrao + centavos + centavoFinal + moedas;
Console.WriteLine(valorExtenso);

    



