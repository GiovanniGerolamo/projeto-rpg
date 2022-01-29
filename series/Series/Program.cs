using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListaSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();

            }
            Console.WriteLine("Obrigado por usar nossos serviços.");
            Console.ReadLine();

        }
        private static void ListaSeries()
        {
            Console.WriteLine("Listar Séries");
            var Lista = repositorio.Lista();
            if (Lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Série Cadastrada.");
                return;
            }
            foreach (var serie in Lista)
            {
                var excluido = serie.RetornaExcluido();
                Console.WriteLine("#ID {0}: - {1} {2}", serie.RetornaId(), serie.RetornaTitulo(), (excluido ? "excluído" : ""));
            }
        }
        private static void InserirSerie()
        {
            Console.WriteLine("inserir nova serie");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));   
            }
            Console.Write("Digite o genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo da serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de inicio da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("digite a descrição da serie: ");
            string entradaDescrição = Console.ReadLine();

            Serie novaSerie = new Serie(Id: repositorio.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescrição);
            repositorio.Insere(novaSerie);
          
        }
        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o Id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo da serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de inicio da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("digite a descrição da serie: ");
            string entradaDescrição = Console.ReadLine();

            Serie atualizaSerie = new Serie(Id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescrição);
            
            repositorio.Atualiza(indiceSerie, atualizaSerie);


        }
        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da Serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);
        }
        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da Serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
        }
        private static string ObterOpcaoUsuario()
        {

            Console.WriteLine();
            Console.WriteLine("informe a opção desejada: ");

            Console.WriteLine("1 - LISTAR SÉRIES");
            Console.WriteLine("2 - INSERIR NOVA SÉRIE");
            Console.WriteLine("3 - ATUALIZAR SÉRIE");
            Console.WriteLine("4 - EXCLUIR SÉRIE");
            Console.WriteLine("5 - VISUALIZAR SÉRIE");
            Console.WriteLine("C - LIMPAR TELA");
            Console.WriteLine("X - SAIR");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }

    }
}
