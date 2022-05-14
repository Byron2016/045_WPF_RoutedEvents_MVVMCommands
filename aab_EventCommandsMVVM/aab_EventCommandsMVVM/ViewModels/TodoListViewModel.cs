using aab_EventCommandsMVVM.Commands;
using aab_EventCommandsMVVM.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace aab_EventCommandsMVVM.ViewModels
{
    public class TodoListViewModel: ObservableObject
    {
        private ObservableCollection<TodoItem> _todoItems;

        public ObservableCollection<TodoItem> TodoItems
        {
            get { 
                return _todoItems; 
            }
            set { 
                _todoItems = value; 
                OnPropertyChanged(nameof(TodoItems));
            }
        }

        public ICommand LoadTodoItemsCommand_TodoListViewModel { get; set; }

        public TodoListViewModel()
        {
            LoadTodoItemsCommand_TodoListViewModel = new LoadTodoItemsCommand(this);
            LoadTodoItemsCommand_TodoListViewModel.Execute(null);
        }

    }
}
