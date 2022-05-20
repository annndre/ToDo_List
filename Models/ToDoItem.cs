using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_List.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public bool IsDone { get; set; }
        public DateTime? Date { get; internal set; }
        public DateTime? CurrentDate { get;  set; }

        //public TimeOnly? Time { get; internal set; }
        public string? Location { get; set; }
        public int Sended_mail { get; set; }
        //public void  Sended_email{get;set;}
    }
  
}
