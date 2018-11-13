using System;
using System.Collections.Generic;
using System.Linq;

namespace Dependencias
{
    class Program
    {
        static void Main(string[] args)
        {

            int op;
             
            Cliente c = new Cliente();
            do
            {


                Console.WriteLine("Digite a op");
                Console.WriteLine("1-para cadastrar\n2-excluir\n3-Para alterar\n0-para sair");


                op = Int32.Parse(Console.ReadLine());
                switch(op){
                    case 1:
                        c.cadCli();
                        break;
                    case 2:
                        c.cliExcluir();
                        break;
                    case 3:
                        c.cliAlterar();
                        break;
                    case 0:
                        Console.WriteLine("VLW FLW");
                        break;


                }


            } while (op != 0);
        }
    }
}
