using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ListViewSample;

public class MainViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Item> Items { get; set; }

    public MainViewModel()
    {
        Items = new ObservableCollection<Item>
            {
                new Item { Name = "Apple", Description = "A sweet red fruit", Price = 1.5 },
                new Item { Name = "Banana", Description = "A long yellow fruit", Price = 0.8 },
                new Item { Name = "Orange", Description = "A citrus fruit", Price = 1.2 }
            };
    }

    public event PropertyChangedEventHandler PropertyChanged;
}

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}