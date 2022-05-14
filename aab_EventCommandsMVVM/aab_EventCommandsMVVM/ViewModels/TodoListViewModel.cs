using aab_EventCommandsMVVM.Models;

namespace aab_EventCommandsMVVM.ViewModels
{
    public class TodoListViewModel: ObservableObject
    {
        private TodoItem _todoItems;

        public TodoItem TodoItems
        {
            get { return _todoItems; }
            set { 
                _todoItems = value; 
                OnPropertyChanged(nameof(TodoItems));
            }
        }

    }
}
