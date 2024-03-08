using System;
using System.Collections.Generic;
using System.Text;
using UriOnlineJudge.BEGINNER;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int opcao = 0;

                    Console.WriteLine("Digite o código de um exercicio:");
                    opcao = int.Parse(Console.ReadLine());

                    List<int> listaExercicios = new List<int> { 1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010 };


                    if (listaExercicios.Contains(opcao))
                    {
                        Console.WriteLine("\nExecutando o exercício " + opcao);
                        if (opcao == 1000)
                        {
                            _1000 uri1000 = new _1000();
                            uri1000.Execute();
                        }

                        else if (opcao == 1001)
                        {
                            _1001 uri1001 = new _1001();
                            uri1001.Execute();
                        }

                        else if (opcao == 1002)
                        {
                            _1002 uri1002 = new _1002();
                            uri1002.Execute();
                        }

                        else if (opcao == 1003)
                        {
                            _1003 uri1003 = new _1003();
                            uri1003.Execute();
                        }

                        else if (opcao == 1004)
                        {
                            _1004 uri1004 = new _1004();
                            uri1004.Execute();
                        }

                        else if (opcao == 1005)
                        {
                            _1005 uri1005 = new _1005();
                            uri1005.Execute();
                        }

                        else if (opcao == 1006)
                        {
                            _1006 uri1006 = new _1006();
                            uri1006.Execute();
                        }

                        else if (opcao == 1007)
                        {
                            _1007 uri1007 = new _1007();
                            uri1007.Execute();
                        }

                        else if (opcao == 1008)
                        {
                            _1008 uri1008 = new _1008();
                            uri1008.Execute();
                        }

                        else if (opcao == 1009)
                        {
                            _1009 uri1009 = new _1009();
                            uri1009.Execute();
                        }

                        else if (opcao == 1010)
                        {
                            _1010 uri1010 = new _1010();
                            uri1010.Execute();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }

                Console.WriteLine("\nDeseja executar outro exercício? (S/N)");
                var continueOption = Console.ReadLine();

                if (continueOption.ToUpper() != "S")
                {
                    break;
                }
            }

        }
    }
}
