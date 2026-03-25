using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HRApp.ViewModels
{
    [QueryProperty("Text","Text")]
    public partial class DetailViewModel:ObservableObject
    {
        [ObservableProperty]
        string text;

        public DetailViewModel()
        {
            var str = Text;
        }

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
