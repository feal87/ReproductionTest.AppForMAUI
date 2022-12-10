using System.Collections.ObjectModel;
using System.ComponentModel;
using TheCouncilLibrary.Entities;

namespace ReproductionTest;

public partial class MainPage : ContentPage
{
    BindingObject localData;

    public MainPage()
    {
        InitializeComponent();
        ObservableCollection<Manga> mangas = new ObservableCollection<Manga>();
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink="http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        mangas.Add(new Manga() { Name = "Test123", BookwalkerLink = "http://www.whatever.com/yes" });
        localData = new BindingObject();
        localData.Mangas = mangas;
        this.BindingContext = localData;
    }

    private class BindingObject : INotifyPropertyChanged
    {
        private ObservableCollection<Manga> _mangas;
        public ObservableCollection<Manga> Mangas
        {
            get
            {
                return _mangas;
            }
            set
            {
                _mangas = value;

                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Mangas)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

