using System;
using System.Collections.Generic;
using Xamarin.Forms;
using static App02.MainPage;

namespace App02
{
    public class SeletorTemplate : DataTemplateSelector
    {

        DataTemplate PessoaFundamental;
        DataTemplate PessoaNaoFundamental;

        public SeletorTemplate()
        {
            PessoaFundamental = new DataTemplate(typeof(Templates.PessoaFundamentalViewCell));
            PessoaNaoFundamental = new DataTemplate (typeof(Templates.PessoaNaoFundamentalViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Pessoa pessoa = item as Pessoa;

            if (pessoa.IsRequired)
            {
                return PessoaFundamental;
            }
            else
            {
                return PessoaNaoFundamental;
            }
        }
    }
}
