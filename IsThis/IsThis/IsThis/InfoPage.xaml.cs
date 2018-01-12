using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IsThis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
            TitleLabel_1.Text = "1 variantas";
            GameLabel_1.Text = "Telefona laikyk prieš save. Aiškinantis žaidėjas/komanda bandys tau padėti atspėti, koks gi žmogus/personažas/įvykis/vieta/citata šįkart įsitaisius tavo telefone!";

        }
    }
}