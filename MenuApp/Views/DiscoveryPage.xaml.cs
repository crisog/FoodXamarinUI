using System;
using System.Collections.Generic;
using MenuApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        DiscoveryButtonView lastElementSelected = new DiscoveryButtonView();
        public DiscoveryPage()
        {
            InitializeComponent();
            BindingContext = new DiscoveryPageViewModel();
        }

        public void Stack_Clicked(object sender, EventArgs e)
        {
            lastElementSelected.BackgroundColor = Color.White;
            var elementSelected = (DiscoveryButtonView)sender;
            elementSelected.BackgroundColor = Color.FromHex("#F9A602");
            lastElementSelected = elementSelected;
        }
    }
}
