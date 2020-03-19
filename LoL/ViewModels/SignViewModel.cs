using LoL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace LoL.ViewModels
{
    public class SignViewModel : BaseViewModel
    {
        private ObservableCollection<CarouselItem> _signs;

        public SignViewModel()
        {
            LoadDrinks();
        }

        public ObservableCollection<CarouselItem> Signs
        {
            get { return _signs; }
            set
            {
                _signs = value;
                OnPropertyChanged();
            }
        }

        void LoadDrinks()
        {
            Signs = new ObservableCollection<CarouselItem>() {
                 new CarouselItem { Image="Communion.png", Title = "BRAZILIAN COFFEE", Color= Color.Maroon, Price =3.5, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="Community.png", Title = "HOT CHOCOLATE WITH MARSHMALLOWS", Color= Color.Wheat, Price = 8, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="Compassion.png", Title = "MILK WITH MINT", Color= Color.Green, Price = 7.99, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="Honesty.png", Title = "MILK WITH MINT", Color= Color.Green, Price = 7.99, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="Honor.png", Title = "MILK WITH MINT", Color= Color.Green, Price = 7.99, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="HumanSpecies.png", Title = "MILK WITH MINT", Color= Color.Green, Price = 7.99, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="nonConLov.png", Title = "MILK WITH MINT", Color= Color.Green, Price = 7.99, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new CarouselItem { Image="UnspokenWorlds.png", Title = "MILK WITH MINT", Color= Color.Green, Price = 7.99, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                new CarouselItem { Image="Consciousness.PNG", Title = "STRAWBERRY MILK", Color= Color.Red, Price = 6.5, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." }
            };
        }
    }
}
