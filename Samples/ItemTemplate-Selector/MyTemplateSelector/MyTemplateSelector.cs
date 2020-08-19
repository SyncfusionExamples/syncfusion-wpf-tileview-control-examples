
using System.Windows;
using System.Windows.Controls;

namespace ItemTemplate_Selector
{
    public class MyTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Template1 { get; set; }
        public DataTemplate Template2 { get; set; }
        public DataTemplate Template3 { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if ((item is TileItem && (item as TileItem).Header == "Item 1") || (item is TileItem && (item as TileItem).Header == "Item 5") || (item is TileItem && (item as TileItem).Header == "Item 9"))
                return Template1;
            else if ((item is TileItem && (item as TileItem).Header == "Item 3") ||( item is TileItem && (item as TileItem).Header == "Item 7"))
                return Template2;
            else
                return Template3;
        }
    }

}
