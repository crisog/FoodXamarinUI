using System;
using System.Windows.Input;
using MenuApp.Models;
using MenuApp.Views;
using Xamarin.Forms;

namespace MenuApp.ViewModels
{
    public class DiscoveryPageViewModel
    {

        DiscoveryButtonView lastElementSelected = new DiscoveryButtonView();
        public ICommand SelectCommand { get; set; }
        public MenuOption MenuOptionBeer { get; set; } = new MenuOption();
        public MenuOption MenuOptionDining { get; set; } = new MenuOption();
        public MenuOption MenuOptionCafe { get; set; } = new MenuOption();
        public MenuOption MenuOptionNearby { get; set; } = new MenuOption();
        public MenuOption MenuOptionFastFood { get; set; } = new MenuOption();
        public MenuOption MenuOptionFeaturedFood { get; set; } = new MenuOption();

        public DiscoveryPageViewModel()
        {
            MenuOptionBeer.BackgroundColor = "White";
            MenuOptionBeer.Image = "https://icons.iconarchive.com/icons/flat-icons.com/flat/256/Beer-icon.png";
            MenuOptionBeer.Title = "Bar and Hotels";
            MenuOptionBeer.Subtitle = "42 Place";

            MenuOptionDining.BackgroundColor = "White";
            MenuOptionDining.Image = "https://icons.iconarchive.com/icons/icons8/windows-8/256/Household-Dining-Room-icon.png";
            MenuOptionDining.Title = "Fine Dining";
            MenuOptionDining.Subtitle = "15 Place";

            MenuOptionCafe.BackgroundColor = "White";
            MenuOptionCafe.Image = "https://icons.iconarchive.com/icons/iconsmind/outline/256/Coffee-icon.png";
            MenuOptionCafe.Title = "Cafes";
            MenuOptionCafe.Subtitle = "28 Place";

            MenuOptionNearby.BackgroundColor = "White";
            MenuOptionNearby.Image = "https://icons.iconarchive.com/icons/paomedia/small-n-flat/256/map-marker-icon.png";
            MenuOptionNearby.Title = "Nearby";
            MenuOptionNearby.Subtitle = "34 Place";

            MenuOptionFastFood.BackgroundColor = "White";
            MenuOptionFastFood.Image = "https://icons.iconarchive.com/icons/sonya/swarm/256/Fast-Food-icon.png";
            MenuOptionFastFood.Title = "Fast Foods";
            MenuOptionFastFood.Subtitle = "29 Place";

            MenuOptionFeaturedFood.BackgroundColor = "White";
            MenuOptionFeaturedFood.Image = "https://icons.iconarchive.com/icons/sonya/swarm/256/Pizza-icon.png";
            MenuOptionFeaturedFood.Title = "Featured Foods";
            MenuOptionFeaturedFood.Subtitle = "21 Place";

            SelectCommand = new Command<object>((sender) =>
            {
                lastElementSelected.BackgroundColor = Color.White;
                var elementSelected = (DiscoveryButtonView)sender;
                elementSelected.BackgroundColor = Color.FromHex("#F9A602");
                lastElementSelected = elementSelected;

            });
        }
    }
}
