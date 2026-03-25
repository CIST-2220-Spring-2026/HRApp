using System.ComponentModel;

namespace HRApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string text;
        public string Text 
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
