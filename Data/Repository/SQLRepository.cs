using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_List.Models;

namespace ToDo_List.Data.Repository 
{
    public class SQLRepository : IRepository
    {
        private readonly DB _context;

        public SQLRepository(DB context)
        {
            _context = context;
           
        }

        public void AddTodo(string todoName,DateTime? NewToDodate,string? LocationItem)
        {
            ToDoItem newItem = new ToDoItem()
            {
                Title = todoName,
                IsDone = false,
                Date = NewToDodate,
                Location = LocationItem,
            };


            _context.toDoItems.Add(newItem);
            _context.SaveChanges();
        }

        public void Date(DateTime? Date)
        {
            _context.Add(Date);
            _context.SaveChanges();
        }
        public void Location(string? LocationItem)
        {
            _context.Add(LocationItem);
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var deletedItem = _context.toDoItems.Find(id);

            if(deletedItem != null)
            {
                _context.toDoItems.Remove(deletedItem);
                _context.SaveChanges();
            }
        }
        //public void SelectDate(DateTime? Date)
        //{
        //    var selectedItem = _context.toDoItems.Find(Date);
        //    //IEnumerable<DateTime>query = _context.toDoItems.SelectMany(ToDoItems=>ToDoItems.Date);
        //    if (selectedItem != null)
        //    {
        //      var p =  _context.toDoItems.Select(ToDoItems=>ToDoItems.Date);
                
        //    }
        //}

        public IEnumerable<ToDoItem> GetAllItems()
        {
            return _context.toDoItems;
           
        }

        public void ValueChanged(ToDoItem changedItem)
        {
           // метод update обновляет все поля , Attach обновляет то поле,что действительно изменилось

            var item = _context.toDoItems.Attach(changedItem);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }
        
    }
}
