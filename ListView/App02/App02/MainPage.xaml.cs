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
                new Grupo ("Presidente", "CEO")
                {
                    new Pessoa { Nome = "José" },
                },
                new Grupo ("Diretores", "Dir.")
                {
                    new Pessoa { Nome = "João" },
                    new Pessoa { Nome = "Maria" },
                },
                new Grupo ("Gerentes", "Ger.")
                {
                    new Pessoa { Nome = "Felipe" },
                    new Pessoa { Nome = "Judas" },
                }
            };
        }

        public class Grupo : List<Pessoa>
        {
            public string Titulo { get; set; }
            public string Abreviacao { get; set; }

            public Grupo(string titulo, string abreviacao)
            {
                Titulo = titulo;
                Abreviacao = abreviacao;
            }
        }

        public class Pessoa
        {
            public string Nome { get; set; }
        }
    }
}
