using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
using Sharpen.IO;

namespace TutorialDB4O
{
    class Program
    {
        static string filename = "";
        static int option = 0;

        static void Main(string[] args)
        {
            filename = Console.ReadLine().Replace("\\","\\");
            while(true)
            {
                Console.WriteLine("1 - Compras\n2 - Jogos");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("Cadastro de compras:\n  1 - adicionar item\n  2 - remover item\n  3 - consultar item");
                    option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        Console.WriteLine("Nome/Descrição: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Preço R$: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.ReadLine();
                        CRUD.Database.Insert(new Model.Compra(nome, preco));
                        option = 0;
                    }
                    if (option == 2)
                    {
                        Console.WriteLine("Nome do item a ser deletado: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Quantidade a ser removida: ");
                        int qtd = int.Parse(Console.ReadLine());
                        CRUD.Database.Delete(new Model.Compra(nome, 0), qtd);
                        option = 0;
                    }
                    if (option == 3)
                    {
                        Console.WriteLine("Nome do item: ");
                        string nome = Console.ReadLine();
                        CRUD.Database.Retrieve(new Model.Compra(nome, 0));
                        option = 0;
                    }
                }

                if (option == 2)
                {
                    Console.WriteLine("Cadastro de jogos:\n  1 - adicionar jogo\n  2 - remover jogo\n  3 - consultar jogo");
                    option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        string nome, descricao, img;
                        Console.WriteLine("Nome do jogo: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Descrição: ");
                        descricao = Console.ReadLine();
                        Console.WriteLine("Imagem: ");
                        img = Console.ReadLine();
                        CRUD.Database.Insert(new Model.Jogo(nome, descricao, img));
                        option = 0;
                    }
                    if (option == 2)
                    {
                        Console.WriteLine("Nome do jogo a ser deletado: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Quantidade a ser removida: ");
                        int qtd = int.Parse(Console.ReadLine());
                        CRUD.Database.Delete(new Model.Jogo(nome, null, null), qtd);
                        option = 0;
                    }
                    if (option == 3)
                    {
                        Console.WriteLine("Nome do jogo: ");
                        string nome = Console.ReadLine();
                        CRUD.Database.Retrieve(new Model.Jogo(nome, null, null));
                        option = 0;
                    }
                }

            
            }
        }
    }
}
