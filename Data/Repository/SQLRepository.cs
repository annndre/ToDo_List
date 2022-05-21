using Microsoft.EntityFrameworkCore;
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

        public void AddTodo(string todoName,DateTime? NewToDodate, DateTime? NewCurrentDate, string? NewDuration, string? LocationItem)
        {
            ToDoItem newItem = new ToDoItem()
            {
                Title = todoName,
                IsDone = false,
                Date = NewToDodate,
                CurrentDate = NewCurrentDate,
                Duration = NewDuration,
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
        public void Duration(string? NewDuration)
        {
            _context.Add(NewDuration);
            _context.SaveChanges();
        }
        public void CurrentDate(DateTime? NewCurrentDate)
        {
            _context.Add(NewCurrentDate);
            _context.SaveChanges();
        }
        public int Sended_mail(int id)
        {
            var item = _context.toDoItems.Find(id);
            var result = item.Sended_mail;

            return result;
        }
        public void Sended_email(int id)
        {
            var item = _context.toDoItems.Find(id);
            item.Sended_mail = 1;
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

        public ToDoItem GetToDoById(int id)
        {
            return _context.toDoItems.FirstOrDefault(b=>b.Id ==  id);
           
           // return _context.FirstOrDefault(id.Equals(id));    
        }

        public bool EditToDo(ToDoItem editedToDo)
        {
            var oldToDo = _context.toDoItems.Find(editedToDo.Id);
            editedToDo.Sended_mail = 2;
            if (oldToDo is not null)
            {
                oldToDo = editedToDo;
                _context.Attach(oldToDo);
                _context.Entry(oldToDo).State = EntityState.Modified;

                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
