using aab_EventCommandsMVVM.Models;
using System.Collections.ObjectModel;

namespace aab_EventCommandsMVVM.ViewModels
{
    public class TodoListViewModel: ObservableObject
    {
        private ObservableCollection<TodoItem> _todoItems;

        public ObservableCollection<TodoItem> TodoItems
        {
            get { return _todoItems; }
            set { 
                _todoItems = value; 
                OnPropertyChanged(nameof(TodoItems));
            }
        }

    }
}
