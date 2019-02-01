using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWinForms.Entities;

namespace ToDoWinForms
{
    class ToDoContext : DbContext
    {
        //public ToDoContext() : base()
        //{

        //}

        public ToDoContext(string dbName) : base(dbName)
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
