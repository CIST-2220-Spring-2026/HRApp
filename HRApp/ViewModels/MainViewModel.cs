using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace HRApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial string Text { get; set; }

        [ObservableProperty]
        public partial ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();

        [RelayCommand]
        public async Task Add()
        {
            if (string.IsNullOrEmpty(Text))
            {
                return;
            }

            Items.Add(Text);

            Text = string.Empty;
        }

        [RelayCommand]
        public void Delete(string s)
        {
            if(Items.Contains(s))
            {
                Items.Remove(s);
            }
        }
    }
}
