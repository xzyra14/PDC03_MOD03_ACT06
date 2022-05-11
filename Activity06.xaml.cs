using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity06 : ContentPage
    {
        public Activity06()
        {
            InitializeComponent();
            {
                this.BindingContext = this;
                this.IsBusy = false;
                this.btnLogin.Clicked += btnLogin_Clicked;
            }

            void btnLogin_Clicked(object sender, EventArgs e)
            {
                this.IsBusy = true;
            }
        }
    }
}