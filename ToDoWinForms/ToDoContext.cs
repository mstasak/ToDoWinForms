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
        // we override convention with a specific database name, so migrations
        // will not use an unindended db name 'ToDoWinForms.ToDoContext'
        public ToDoContext() : base("ToDos")
        {

        }

        public ToDoContext(string dbName) : base(dbName)
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
