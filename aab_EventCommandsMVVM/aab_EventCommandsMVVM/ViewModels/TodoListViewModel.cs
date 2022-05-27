using aab_EventCommandsMVVM.Commands;
using aab_EventCommandsMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace aab_EventCommandsMVVM.ViewModels
{
    public class TodoListViewModel: ObservableObject
    {
        public string Title { get; set; }

        private ObservableCollection<TodoItem> _todoItems;

        public ObservableCollection<TodoItem> TodoItems
        {
            get { return _todoItems; }
            set { 
                _todoItems = value; 
                OnPropertyChanged(nameof(TodoItems));
            }
        }

        public ICommand LoadTodoItemsCommand { get; set; }

        public ICommand SelectedTodoItemsChangedCommand { get; set; }

        public TodoListViewModel()
        {
            Title = "Titulo";
            LoadTodoItemsCommand = new LoadTodoItemsCommand(this);
            //LoadTodoItemsCommand.Execute(null);
        }
    }
}
