using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVMLogic
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial int Counter { get; set; }

        [RelayCommand]
        public void IncrementCounter()
        {
            Counter++;
        }

        [RelayCommand]
        public void DecrementCounter()
        {
            Counter--;
        }
    }
}
