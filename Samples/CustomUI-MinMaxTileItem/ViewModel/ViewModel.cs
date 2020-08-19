using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximized_TileItem
{
    public class TileViewItems : ObservableCollection<TileViewItem>
    {
    }

    class ViewModel : NotificationObject
    {
        private TileViewItems tileViewItems;

        public TileViewItems TileViewItems
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
            tileViewItems = new TileViewItems();
        }
    }
}
