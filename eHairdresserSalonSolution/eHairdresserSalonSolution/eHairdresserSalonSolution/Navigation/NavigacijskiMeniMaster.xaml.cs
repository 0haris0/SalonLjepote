using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eHairdresserSalonSolution.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigacijskiMeniMaster : ContentPage
    {
        public ListView ListView;

        public NavigacijskiMeniMaster()
        {
            InitializeComponent();

            BindingContext = new NavigacijskiMeniMasterViewModel();
            ListView = MenuItemsListView;
        }

        class NavigacijskiMeniMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<NavigacijskiMeniMenuItem> MenuItems { get; set; }
            
            public NavigacijskiMeniMasterViewModel()
            {
                MenuItems = new ObservableCollection<NavigacijskiMeniMenuItem>(new[]
                {
                    new NavigacijskiMeniMenuItem { Title = "Pregled tretmana", ImageSource = "pregledTretmana.png", TargetType=typeof(PregledTretmana) },
                    new NavigacijskiMeniMenuItem { Title = "Moji termini", ImageSource = "mojiTermini.png", TargetType=typeof(MojiTermini) },
                    new NavigacijskiMeniMenuItem { Title = "Pregled termina", ImageSource = "pregledTermina.png", TargetType=typeof(PregledTermina) },
                    new NavigacijskiMeniMenuItem { Title = "Pregled frizera", ImageSource = "pregledFrizera.png", TargetType=typeof(PregledFrizera) },
                    new NavigacijskiMeniMenuItem { Title = "Pregled takmičenja", ImageSource = "pregledTakmicenja.png", TargetType=typeof(PregledTakmicenja) },
                    new NavigacijskiMeniMenuItem { Title = "Moja takmičenja", ImageSource = "mojaTakmicenja.png", TargetType=typeof(MojaTakmicenja) },
                    new NavigacijskiMeniMenuItem { Title = "Odjavi se", ImageSource = "odjaviSE.png", TargetType=typeof(Login) },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}