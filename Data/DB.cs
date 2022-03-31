using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_List.Models;

namespace ToDo_List.Data
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options ) : base(options) { }
       
        public DbSet<ToDoItem> toDoItems { get; set; }

    }
}
