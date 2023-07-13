using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Valores de faturamento mensal por estado
        decimal sp = 67836.43m;
        decimal rj = 36678.66m;
        decimal mg = 29229.88m;
        decimal es = 27165.48m;
        decimal outros = 19849.53m;

        // Calcular o valor total mensal
        decimal valorTotalMensal = sp + rj + mg + es + outros;

        // Calcular o percentual de representação de cada estado
        decimal percentualSP = (sp / valorTotalMensal) * 100;
        decimal percentualRJ = (rj / valorTotalMensal) * 100;
        decimal percentualMG = (mg / valorTotalMensal) * 100;
        decimal percentualES = (es / valorTotalMensal) * 100;
        decimal percentualOutros = (outros / valorTotalMensal) * 100;

        // Imprimir os resultados
        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine("SP: {0}%", Math.Round(percentualSP));
        Console.WriteLine("RJ: {0}%", Math.Round(percentualRJ));
        Console.WriteLine("MG: {0}%", Math.Round(percentualMG));
        Console.WriteLine("ES: {0}%", Math.Round(percentualES));
        Console.WriteLine("Outros: {0}%", Math.Round(percentualOutros));
    }
}
