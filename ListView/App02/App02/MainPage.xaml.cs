using System.Collections.Generic;
using Xamarin.Forms;

namespace App02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ListaFuncionarios.ItemsSource = GetFuncionarios();
        }

        private List<Grupo> GetFuncionarios()
        {
            return new List<Grupo>
            {
                new Grupo ("Presidente", "CEO", "Presidente da empresa")
                {
                    new Pessoa { Nome = "José" },
                },
                new Grupo ("Diretores", "Dir.", "Fazem parte do conselho e auxiliam nas tomadas de decisões")
                {
                    new Pessoa { Nome = "João" },
                    new Pessoa { Nome = "Maria" },
                },
                new Grupo ("Gerentes", "Ger.", "Gerenciam o desempenho e funções dos funcionários")
                {
                    new Pessoa { Nome = "Felipe" },
                    new Pessoa { Nome = "Judas" },
                },
                new Grupo ("Funcionários", "Func.", "Realizam atividades específicas com base em sua profissão")
                {
                    new Pessoa { Nome = "Lucas" },
                    new Pessoa { Nome = "Danilo" },
                    new Pessoa { Nome = "Jéssica" },
                    new Pessoa { Nome = "Pedro" },
                    new Pessoa { Nome = "Fernanda" },
                    new Pessoa { Nome = "Ellen" },
                    new Pessoa { Nome = "Luan" },
                    new Pessoa { Nome = "Carlos" },
                    new Pessoa { Nome = "Amanda" },
                }
            };
        }

        public class Grupo : List<Pessoa>
        {
            public string Titulo { get; set; }
            public string Abreviacao { get; set; }
            public string Descricao { get; set; }

            public Grupo(string titulo, string abreviacao, string descricao)
            {
                Titulo = titulo;
                Abreviacao = abreviacao;
                Descricao = descricao;
            }
        }

        public class Pessoa
        {
            public string Nome { get; set; }
        }
    }
}
