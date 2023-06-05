using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp10.Model;

namespace WpfApp10.ViewModel
{
    class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ObservableCollection<string> _categories;
        UserContext context;
        public MenuViewModel()
        {
            context = new UserContext();
            _categories = new ObservableCollection<string>();
            foreach (Category category in context.Categories)
            {
                Categories.Add(category.Name);
            }
            Notify("Categories");
        }
        public ObservableCollection<string> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                Notify("Categories");
            }
        }
        void Notify(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
