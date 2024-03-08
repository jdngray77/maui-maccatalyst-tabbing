using CommunityToolkit.Mvvm.ComponentModel;

namespace BindableLayout.ViewModel
{
    public partial class ItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool isReadOnly;

        public ItemViewModel(bool isReadOnly)
        {
            this.isReadOnly = isReadOnly;
        }
    }
}