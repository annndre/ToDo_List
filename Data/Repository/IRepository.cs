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

        ToDoItem GetToDoById(int id);
        bool EditToDo(ToDoItem editedToDo);
        void AddTodo(string todoName,DateTime? NewToDodate, DateTime? NewCurrentDate, string NewDuration, string? LocationItem);
        void ValueChanged(ToDoItem changedItem);
        void Date(DateTime? Date);
        void CurrentDate(DateTime? CurrentDate);
        void Duration(string? Duration);
        void Location(string? Location);
        void DeleteItem(int id);
        int Sended_mail(int id);
        void Sended_email(int id);
    } 
}
