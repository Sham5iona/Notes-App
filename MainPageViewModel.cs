using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Notes.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string input;

        [ObservableProperty]
        ObservableCollection<string> notes;

        public MainPageViewModel()
        {
            Notes = new ObservableCollection<string>();
        }

        [RelayCommand]
        private void AddItem()
        {
            if (!string.IsNullOrWhiteSpace(Input))
            {
                Notes.Add(Input);
                Input = string.Empty;
            }
        }

        [RelayCommand]
        private void DeleteItem(string value)
        {
            if(Notes.Contains(value))
            {
                Notes.Remove(value);
            }
        }
    }
}
