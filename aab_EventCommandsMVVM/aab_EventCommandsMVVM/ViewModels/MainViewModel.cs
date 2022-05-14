using aab_EventCommandsMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aab_EventCommandsMVVM.ViewModels
{
    public class MainViewModel: ObservableObject
    {
        private TodoListViewModel _todoListViewModel;

        public TodoListViewModel TodoListViewModel
        {
            get { return _todoListViewModel; }
            set { _todoListViewModel = value; }
        }

        public MainViewModel(TodoListViewModel todoListViewModel)
        {
            _todoListViewModel = todoListViewModel;
        }

    }
}
