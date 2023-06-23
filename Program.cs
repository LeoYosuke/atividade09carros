using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade09carro
{
    class Program
    {
        static List<string> carros = new List<string>(){ "[______]", "[______]", "[______]", "[______]", "[______]" };

    static void Main(string[] args)
        {
            string placa;
            int opcao;
            Console.WriteLine(""); 
            Console.WriteLine("");
            Console.WriteLine("Bem-Vindo ao Estaciona facil");
            Console.WriteLine("1 - Estacionar:");
            Console.WriteLine("2 - Retirar veiculo:");
            Console.WriteLine("3 - Listar veiculos");
            Console.WriteLine("\n");
            Console.WriteLine("digite uma opção:");
            opcao = Int32.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Selecione o indice da vaga que você deseja estacionar: ");
                int vaga = int.Parse(Console.ReadLine());
                if (vaga > 5)
                {

                    Console.WriteLine("Desculpa sem vagas disponiveis...");
                    Main(null);

                }
                else
                {
                    vaga = vaga - 1;
                    if (carros[vaga] == "[______]")
                    {
                        Console.WriteLine("Esta vaga está disponivel!! (5 vagas)");
                        Console.WriteLine("digite a placa do carro:");
                        placa = (Console.ReadLine());
                       

                        if (placa.Length == 6)
                        {
                            placa = "[" + placa.ToUpper() + "]";
                            carros[vaga] = placa;
                            Console.WriteLine("carro estacionado com sucesso!!!");
                            Main(null);
                        }
                        else
                        {
                            Console.WriteLine("placa inválida!! ");
                            Main(null);
                        }

                    
                    }
                
            }
                }
            if (opcao == 2)
            {
                Console.WriteLine("Para retirar digite sua placa:");
                placa = Console.ReadLine();
                if (placa.Length != 6)
                {
                    Console.WriteLine("\nplaca inválida!");
                    Main(null);
                }
                else
                {
                    placa = "[" + placa.ToUpper() + "]";

                    int cont = 0;
                    while (cont < carros.Count)
                    {

                        if (carros[cont] == placa)
                        {
                            carros[cont] = "[______]";
                            Console.WriteLine("\nVeículo removido com sucesso!");
                            Main(null);
                            break;
                        }
                        cont++;
                    }
                    if (cont + 1 == 7)
                    {
                        Console.WriteLine("\nVeículo não encontrado...");
                        Main(null);
                    }
                }

            }
            if (opcao == 3)
            {
                int cont = 0;
                string lista = "";
                while (cont < carros.Count)
                {


                    lista = lista + " " + carros[cont];
                    cont++;
                }

                Console.Write($"\nLista de vagas: {lista}");
                Console.ReadKey();
                Main(null);
            }

        }
    }
}
