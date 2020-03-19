using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LoL.Models;
using System.Threading.Tasks;
using LoL.ViewModels;

namespace LoL.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class SignPage : ContentPage
    {
        
        //Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public SignPage()
        {
            InitializeComponent();
            BindingContext = new SignViewModel();
            //this.gridDescription.IsVisible = false;
        }

        public  void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //if(this.gridDescription.IsVisible == true)
            //    this.gridDescription.IsVisible = false;
            //else
            //    this.gridDescription.IsVisible = true;
        }
    }
}