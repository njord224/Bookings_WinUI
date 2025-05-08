using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVMLogic
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial int Month { get; set; }


        [RelayCommand]
        public void SetNewMonth(int month)
        {
            Month = month;
        }
    }
}
