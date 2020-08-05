
using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Arrange_Items
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<TileItem> tileViewItems;
        private bool allowItemRepositioning= true;
        private int rowCount=4;
        private int columnCount = 3;
        private ScrollBarVisibility horizontalScrollBarVisibility = ScrollBarVisibility.Auto;
        private ScrollBarVisibility verticalScrollBarVisibility = ScrollBarVisibility.Auto;
        private bool enableAnimation=true;
        
        public ScrollBarVisibility HorizontalScrollBarVisibility
        {
            get
            {
                return horizontalScrollBarVisibility;
            }
            set
            {
                horizontalScrollBarVisibility = value;
                this.RaisePropertyChanged(nameof(HorizontalScrollBarVisibility));
            }
        } 
        
        public ScrollBarVisibility VerticalScrollBarVisibility
        {
            get
            {
                return verticalScrollBarVisibility;
            }
            set
            {
                verticalScrollBarVisibility = value;
                this.RaisePropertyChanged(nameof(VerticalScrollBarVisibility));
            }
        }

        public bool AllowItemRepositioning
        {
            get
            {
                return allowItemRepositioning;
            }
            set
            {
                allowItemRepositioning = value;
                this.RaisePropertyChanged(nameof(AllowItemRepositioning));
            }
        }
        
        public bool EnableAnimation
        {
            get
            {
                return enableAnimation;
            }
            set
            {
                enableAnimation = value;
                this.RaisePropertyChanged(nameof(EnableAnimation));
            }
        }
        
        public int RowCount
        {
            get
            {
                return rowCount;
            }
            set
            {
                rowCount = value;
                this.RaisePropertyChanged(nameof(RowCount));
            }
        }
        
        public int ColumnCount
        {
            get
            {
                return columnCount;
            }
            set
            {
                columnCount = value;
                this.RaisePropertyChanged(nameof(ColumnCount));
            }
        }
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
            TileViewItems.Add(new TileItem() { Header = "Item 10", Content = "Content 10" });
        }
    }
}
