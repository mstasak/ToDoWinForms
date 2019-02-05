using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoWinForms.Entities;

namespace ToDoWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //SetupDbManual();
            //No! Use migrations instead.  
            //In NuGet Package Manager:
            //PM> Add - Migration Initial
            //PM> Update - Database

            Application.Run(new MainForm());
        }

        //this will create db from entity classes, named "dbcontextnamespace.dbcontextclassname", i.e. ToDoWinForms.ToDoContext (this default name can be overridden)
        //"ToDos" overrides default name
        //For some reason, this creates duplicates of each added row on initial startup - some needed identity id column attribute?
        //nope, AVG was interrupting scanning and relaunching, causing code to run twice :(
        static void SetupDbManual() {
            Console.WriteLine("Adding item");
                using (var ctx = new ToDoContext("ToDos")) {
                var toDoItem = new ToDoItem() {ItemName = "WakeUp", Description = "Turn off alarm and get out of bed.", Completed = false};
                ctx.ToDoItems.Add(toDoItem);
                //var toDoItem2 = new ToDoItem() {ItemName = "Eat", Description = "Breakfast.", Completed = false};
                //ctx.ToDoItems.Add(toDoItem2);
                ctx.SaveChanges();
            }
        }
    }
}
