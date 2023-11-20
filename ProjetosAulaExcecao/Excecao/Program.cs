using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bloco de execução protegida !!!
            // O bloco try tenta executar todas as instruções
            // Se ocorrer algum erro, a execução é pulada/desviada para os blocos catch
            try
            {
                //gera erro/exceção de divisão por zero
                int a = 10;
                int b = 0;
                int result = a / b;

                //gera erro/exceção de "estouro" de variável 
                //(valor é muito grande ou muito pequeno para a variável)
                double numero_real = double.Parse("10e9999");

                //gera um erro/exceção de conversão de string
                int numero_inteiro = int.Parse("IFSP - Campinas");

                //acesso a indice inválido de vetor (IndexOutOfRangeException)
                int[] vetor = new int[10];
                vetor[15] = 5;


                //cria e dispara uma exceção padrão
                throw new Exception("Alguma mensagem de erro !!!");


                //cria e dispara uma exceção definida pelo usuário
                throw new ErroCriticoException(100, "Falha catastrófica!");


                //Nenhuma exceção foi disparada
                Console.WriteLine("Bloco Try Completamente Executado !!!");

            }

            //trata a exceção gerada quando ocorre uma divisão por zero
            catch (DivideByZeroException erro)
            {
                Console.WriteLine("\nCatch DivideByZeroException: divisão por zero !!!");
                Console.WriteLine("\n\tException:  " + erro.GetType());
                Console.WriteLine("\n\tMessage:    " + erro.Message);
                Console.WriteLine("\n\tSource:     " + erro.Source);
                Console.WriteLine("\n\tTargetSite: " + erro.TargetSite);
                Console.WriteLine("\n\tStackTrace: " + erro.StackTrace);

            }

            //trata a exceção gerada quando ocorre um estouro de variavel
            catch (OverflowException erro)
            {
                Console.WriteLine("\nCatch OverflowException: estouro de variável !!!");
                Console.WriteLine("\n\tException:  " + erro.GetType());
                Console.WriteLine("\n\tMessage:    " + erro.Message);
                Console.WriteLine("\n\tSource:     " + erro.Source);
                Console.WriteLine("\n\tTargetSite: " + erro.TargetSite);
                Console.WriteLine("\n\tStackTrace: " + erro.StackTrace);
            }

            //trata a exceção gerada pelo método "Parse" quando a string
            //passada não representa um valor numérico (formato do texto inválido)
            catch (FormatException erro)
            {
                Console.WriteLine("\nCatch FormatException: Formato de texto inválido !!!");
                Console.WriteLine("\n\tException:  " + erro.GetType());
                Console.WriteLine("\n\tMessage:    " + erro.Message);
                Console.WriteLine("\n\tSource:     " + erro.Source);
                Console.WriteLine("\n\tTargetSite: " + erro.TargetSite);
                Console.WriteLine("\n\tStackTrace: " + erro.StackTrace);
            }

            //trata a exceção definida pelo usuário
            catch (ErroCriticoException erro)
            {
                Console.WriteLine("\nCatch ErroCriticoException: Exceção definada pelo usuário");
                Console.WriteLine("\n\tValor:  " + erro.getValor());
                Console.WriteLine("\n\tTexto:  " + erro.getTexto());
                Console.WriteLine("\n\tException:  " + erro.GetType());
                Console.WriteLine("\n\tMessage:    " + erro.Message);
                Console.WriteLine("\n\tSource:     " + erro.Source);
                Console.WriteLine("\n\tTargetSite: " + erro.TargetSite);
                Console.WriteLine("\n\tStackTrace: " + erro.StackTrace);
            }

            //é executado para qualquer tipo exceção
            //deixar sempre no final !!!
            catch (Exception erro)
            {
                Console.WriteLine("\nCatch Exception: captura qualquer exceção gerada !!!");
                Console.WriteLine("\n\tException:  " + erro.GetType());
                Console.WriteLine("\n\tMessage:    " + erro.Message);
                Console.WriteLine("\n\tSource:     " + erro.Source);
                Console.WriteLine("\n\tTargetSite: " + erro.TargetSite);
                Console.WriteLine("\n\tStackTrace: " + erro.StackTrace);
            }

            //Sempre é executado, ocorrendo uma exceção ou não!!!
            finally
            {
                // Instruções sempre executadas, ocorram ou não erros
                Console.WriteLine("\nBloco Finally Executado !!!");
            }

            //conseguiu chegar no final do programa
            Console.WriteLine("\nFim da execução do programa !!!\n");
        }
    }
}
