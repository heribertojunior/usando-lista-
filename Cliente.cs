using System;
using System.Collections.Generic;
using System.Linq;
namespace Dependencias
{
    public class Cliente
    {
        List<String> lista = new List<string>();
        public void cadCli(){
            Console.Clear();
            String nome;
            Console.WriteLine("Dgite o Nome");
            nome = Console.ReadLine().Trim().ToUpper();
            if (lista.Contains(nome) == true)
            {
                Console.Clear();

                Console.WriteLine("Nome ja esta em uso");
                Console.ReadKey();
            }
            else
            {
                lista.Add(nome);

            }
            Console.Clear();
            listarIndex();
            Console.WriteLine("QTD " + lista.Count);
            Console.ReadKey();
            Console.Clear();
            

        }
        public void cliExcluir(){
            Console.Clear();
            String nome1;
            List<String> listaantiga = new List<string>();
            foreach (String x in lista)
            {
                listaantiga.Add(x);

            }
            Console.WriteLine("Dgite o Nome para excluir");
            nome1 = Console.ReadLine().Trim().ToUpper();
            if (lista.Contains(nome1) == true)
            {
                lista.Remove(nome1);

            }
            else
            {
                Console.WriteLine("Nome invalido");
            }


            Console.Clear();
            listar();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Lista antiga:");
            foreach (String x in listaantiga)
                {
                    Console.WriteLine("NOME: " + x + " Index: " + lista.IndexOf(x));
                }



            Console.WriteLine("QTD " + lista.Count);
            Console.ReadKey();
            Console.Clear();

        }
        public void listarIndex(){
            foreach (String x in lista)
            {
                Console.WriteLine("NOME: " + x + " Index: " + lista.IndexOf(x));
            }
        }
        public void listar(){
            foreach (String x in lista)
            {
                Console.WriteLine("NOME: " + x);
            }
        }
        public void cliAlterar(){
            Console.Clear();
            listarIndex();
            Console.WriteLine("Informe o index do nome a ser alterado");
            int num = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite o novo nome ");
            String nome2 = Console.ReadLine().Trim().ToUpper();
            lista[num] = nome2;
            Console.Clear();
            listarIndex();
            Console.ReadKey();
            Console.Clear();
        }
        public Cliente()
        {
        }
    }
}
