using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Min_Max_TileItem
{
    public class TileViewItems : ObservableCollection<TileViewItem>
    {
    }

    class ViewModel :NotificationObject
    {
        private MinimizedItemsOrientation minimizedItemsOrientation= MinimizedItemsOrientation.Bottom;
        private double minimizedItemsPercentage=50;
        private bool clickHeaderToMaximize =true;
        private bool isMinMaxButtonOnMouseOverOnly= false;
        private TileViewItems tileViewItems;
        private Visibility splitterVisibility= Visibility.Visible;
        private Brush splitterColor= Brushes.Red;
        private int splitterThickness = 3;

        public TileViewItems TileViewItems
        {
            get { return tileViewItems; }
            set
            {
                tileViewItems = value;
                this.RaisePropertyChanged(nameof(TileViewItems));
            }
        }

        public MinimizedItemsOrientation MinimizedItemsOrientation
        {
            get
            {
                return minimizedItemsOrientation;
            }
            set
            {
                minimizedItemsOrientation = value;
                this.RaisePropertyChanged(nameof(MinimizedItemsOrientation));
            }
        }
        
        public double MinimizedItemsPercentage
        {
            get
            {
                return minimizedItemsPercentage;
            }
            set
            {
                minimizedItemsPercentage = value;
                this.RaisePropertyChanged(nameof(MinimizedItemsPercentage));
            }
        }
        
        public bool ClickHeaderToMaximize
        {
            get
            {
                return clickHeaderToMaximize;
            }
            set
            {
                clickHeaderToMaximize = value;
                this.RaisePropertyChanged(nameof(ClickHeaderToMaximize));
            }
        }
        
        public bool IsMinMaxButtonOnMouseOverOnly
        {
            get
            {
                return isMinMaxButtonOnMouseOverOnly;
            }
            set
            {
                isMinMaxButtonOnMouseOverOnly = value;
                this.RaisePropertyChanged(nameof(IsMinMaxButtonOnMouseOverOnly));
            }
        }
        
        public Visibility SplitterVisibility
        {
            get
            {
                return splitterVisibility;
            }
            set
            {
                splitterVisibility = value;
                this.RaisePropertyChanged(nameof(SplitterVisibility));
            }
        }
        
        public Brush SplitterColor
        {
            get
            {
                return splitterColor;
            }
            set
            {
                splitterColor = value;
                this.RaisePropertyChanged(nameof(SplitterColor));
            }
        }
        
        public int SplitterThickness
        {
            get
            {
                return splitterThickness;
            }
            set
            {
                splitterThickness = value;
                this.RaisePropertyChanged(nameof(SplitterThickness));
            }
        }


        public ViewModel()
        {
            tileViewItems = new TileViewItems();
        }
    }
}
