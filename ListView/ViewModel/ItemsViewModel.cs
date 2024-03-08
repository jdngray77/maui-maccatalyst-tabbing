using System.Collections.ObjectModel;

namespace BindableLayout.ViewModel
{
    public class ItemsViewModel
    {
        public ObservableCollection<ItemViewModel> ItemViewModels { get; } =
            new ObservableCollection<ItemViewModel>();

        public ItemsViewModel()
        {
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(true));
            ItemViewModels.Add(new ItemViewModel(true));
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(true));
            ItemViewModels.Add(new ItemViewModel(true));
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(true));
            ItemViewModels.Add(new ItemViewModel(true));
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(true));
            ItemViewModels.Add(new ItemViewModel(true));
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(false));
            ItemViewModels.Add(new ItemViewModel(true));
            ItemViewModels.Add(new ItemViewModel(true));
        }
    }
}