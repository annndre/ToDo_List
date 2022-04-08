using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_List.Models;

namespace ToDo_List.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<ToDoItem> GetAllItems();
        void AddTodo(string todoName,DateTime? NewToDodate);
        void ValueChanged(ToDoItem changedItem);
        void Date(DateTime Date);
       // void Time(TimeOnly Time);
        void DeleteItem(int id);
    } 
}
