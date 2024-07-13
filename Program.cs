/* Escrever um algoritmo que leia informações sobre um grupo de 250 pessoas e calcule alguns dados estatísticos. 
Para cada pessoas do grupo deve ler o nome da pessoa, a altura, o peso e o sexo (“F” para feminino e “M” para o masculino). 
Calular e escrever:
A quantidade total de homens e mulheres e o percentual de cada.
A média de peso das pessoas (somatório dos pesos de todas as pessoas pela quantidade de pessoas) o nome da pessoa mais alta. */

using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

namespace ex12;

class Program
{
    static void Main(string[] args)
    {
         int quantidadePessoas = 3;
         string nome = "";
         double altura = 0f;
         int peso = 0;
         string sexo = "";
         int quantidadeHomens = 0;
         int quantidadeMulheres = 0;



         for (int i = 1; i <= quantidadePessoas; i++)
         {
            Console.WriteLine("Digite o nome da pessoa [i]: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o seu peso: ");
            peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o seu sexo: 'M' ou 'F'");
            sexo = Console.ReadLine();

          if (sexo == "M")
          { 
             quantidadeHomens += 1;

          } else if (sexo == "F")
          {
             quantidadeMulheres += 1;
          }
        }

            double percentualHomens = (double)quantidadeHomens / (double)quantidadePessoas * 100;
            double percentualMulheres = (double)quantidadeMulheres / (double)quantidadePessoas * 100;

          
         

            Console.WriteLine($"Quantidade de homens: {quantidadeHomens}");
            Console.WriteLine($"Quantidade de mulheres: {quantidadeMulheres}");
            Console.WriteLine($"Percentual de homens: {percentualHomens} ");
            Console.WriteLine($"Percentual de mulheres: {percentualMulheres}");

         }

      
}
