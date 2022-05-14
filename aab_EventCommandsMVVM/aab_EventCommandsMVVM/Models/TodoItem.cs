using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aab_EventCommandsMVVM.Models
{
    public class TodoItem
    {
        public string Description { get; set; }
        public string OwnerName { get; set; }
        public bool IsCompleted { get; set; }
    }
}
