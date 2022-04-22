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
        void AddTodo(string todoName,DateTime? NewToDodate,string? LocationItem);
        void ValueChanged(ToDoItem changedItem);
        void Date(DateTime? Date);
        //void Time(TimeOnly? Time);
        void Location(string? Location);
        void DeleteItem(int id);
    } 
}
