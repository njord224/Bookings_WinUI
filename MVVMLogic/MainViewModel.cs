using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMLogic
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial int Counter { get; set; }
    }
}
