using System;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite o numero do DDD pretendido: ");
            int x = int.Parse(Console.ReadLine());
            string ddd = Endereco(x);

            Console.WriteLine(ddd);
        }

        private static string Endereco(int a)
        {
            string ddd;
            switch (a)
            {
                case 61:
                    ddd = "Brasilia";
                    break;
                case 71:
                    ddd = "Salvador";
                    break;
                case 11:
                    ddd = "Sao Paulo";
                    break;
                case 21:
                    ddd = "Rio de Janeiro";
                    break;
                case 32:
                    ddd = "Juiz de Fora";
                    break;
                case 19:
                    ddd = "Campinas";
                    break;
                case 27:
                    ddd = "Vitoria";
                    break;
                case 31:
                    ddd = "Belo Horizonte";
                    break;
                default:
                    ddd = "DDD nao cadastrado";
                    break;

            }
            return ddd; ;
        }



    }
}