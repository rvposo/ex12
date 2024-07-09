/* Escrever um algoritmo que leia informações sobre um grupo de 250 pessoas e calcule alguns dados estatísticos. 
Para cada pessoas do grupo deve ler o nome da pessoa, a altura, o peso e o sexo (“F” para feminino e “M” para o masculino). 
Calular e escrever:
A quantidade total de homens e mulheres e o percentual de cada.
A média de peso das pessoas (somatório dos pesos de todas as pessoas pela quantidade de pessoas) o nome da pessoa mais alta. */

namespace ex12;

class Program
{
    static void Main(string[] args)
    {
         int quantidadePessoas = 10;
         string nome = "";
         double altura = 0f;



         for (int i = 0; i <= quantidadePessoas; i++)
         {
            Console.WriteLine("Digite o nome da pessoa: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            
         }



                 
    }
}
