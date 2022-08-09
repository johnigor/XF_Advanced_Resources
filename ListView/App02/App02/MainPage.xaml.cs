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
                    new Pessoa { Nome = "José", IsRequired = true, Eficiencia = 8},
                },
                new Grupo ("Diretores", "Dir.", "Fazem parte do conselho e auxiliam nas tomadas de decisões")
                {
                    new Pessoa { Nome = "João", IsRequired = false },
                    new Pessoa { Nome = "Maria", IsRequired = true, Eficiencia = 8 },
                },
                new Grupo ("Gerentes", "Ger.", "Gerenciam o desempenho e funções dos funcionários")
                {
                    new Pessoa { Nome = "Felipe", IsRequired = true, Eficiencia = 9 },
                    new Pessoa { Nome = "Judas", IsRequired = false },
                },
                new Grupo ("Funcionários", "Func.", "Realizam atividades específicas com base em sua profissão")
                {
                    new Pessoa { Nome = "Lucas", IsRequired = false },
                    new Pessoa { Nome = "Danilo", IsRequired = false },
                    new Pessoa { Nome = "Jéssica", IsRequired = false },
                    new Pessoa { Nome = "Pedro", IsRequired = true, Eficiencia = 6 },
                    new Pessoa { Nome = "Fernanda", IsRequired = false },
                    new Pessoa { Nome = "Ellen", IsRequired = false },
                    new Pessoa { Nome = "Luan", IsRequired = false },
                    new Pessoa { Nome = "Carlos", IsRequired = false },
                    new Pessoa { Nome = "Amanda", IsRequired = false },
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
            public double Eficiencia { get; set; } //0 a 10
            public bool IsRequired { get; set; }
        }
    }
}
