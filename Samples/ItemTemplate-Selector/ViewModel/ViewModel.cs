
using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;

namespace ItemTemplate_Selector
{
    class ViewModel : NotificationObject
    {
        private ObservableCollection<TileItem> tileViewItems;

        public ObservableCollection<TileItem> TileViewItems
        {
            get { return tileViewItems; }
            set
            {
                tileViewItems = value;
                this.RaisePropertyChanged(nameof(TileViewItems));
            }
        }

        public ViewModel()
        {
            tileViewItems = new ObservableCollection<TileItem>();
            PopulateCollection();
        }

        public void PopulateCollection()
        {
            //Adding the tileview items into the collection
            TileViewItems.Add(new TileItem() { Header = "Item 1", Content = "Content 1" });
            TileViewItems.Add(new TileItem() { Header = "Item 2", Content = "Content 2" });
            TileViewItems.Add(new TileItem() { Header = "Item 3", Content = "Content 3" });
            TileViewItems.Add(new TileItem() { Header = "Item 4", Content = "Content 4" });
            TileViewItems.Add(new TileItem() { Header = "Item 5", Content = "Content 5" });
            TileViewItems.Add(new TileItem() { Header = "Item 6", Content = "Content 6" });
            TileViewItems.Add(new TileItem() { Header = "Item 7", Content = "Content 7" });
            TileViewItems.Add(new TileItem() { Header = "Item 8", Content = "Content 8" });
            TileViewItems.Add(new TileItem() { Header = "Item 9", Content = "Content 9" });
        }
    }
}
