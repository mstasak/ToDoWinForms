namespace ToDoWinForms.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoWinForms.ToDoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDoWinForms.ToDoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.ToDoItems.Add(new ToDoItem() { ItemName = "WakeUp", Description = "Turn off alarm and get out of bed.", Completed = false });
            context.ToDoItems.Add(new ToDoItem() { ItemName = "Dress", Description = "...", Completed = false });
            context.ToDoItems.Add(new ToDoItem() { ItemName = "Eat", Description = "Breakfast", Completed = false });
            context.ToDoItems.Add(new ToDoItem() { ItemName = "Work", Description = "...", Completed = false });
            context.ToDoItems.Add(new ToDoItem() { ItemName = "Solve world's problems", Description = "...", Completed = false });


        }
    }
}
