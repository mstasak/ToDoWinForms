# ToDoWinForms
ToDo Sample Project in C# (VS 2017 CE), Windows Forms, EF 6.x, SQL Server 2016 LocalDB

Fairly new, but it works.  This is a learning project, not a viable product - a realistic to do list would include categories, assignees, task priorities, due dates, schedule modes like days of week, difficulty estimates, auto-repeat schedules, snooze policies, auto-escalation of priority for overdue items, daily plan view, history, daily performance scoring, holidays, etc. etc. etc.

I'm planning to create a series of projects based on a simple single form (or close to it) daily task to-do list.

The point of the project is to show in a limited amount of code different approaches to .NET data apps, and establish some starter baselines for more elaborate projects.

These projects will use different project types:
- Windows Forms
- WPF
- ASP.NET Web Forms
- ASP.NET Core 2.x MVC
- ASP.NET Core 2.x Razor Pages

These projects will use different database back ends:
- SQL Express LocalDB
- SQLite
- MySQL
- perhaps others (Oracle[Express]? PostgreSQL? MongoDB? MariaDB? CouchDB? CockroachDB? ... simple XML file on a cloud file server?)

These projects will use different ORM layers:
- raw DAO
- Entity Framework 6 (Core? Fluent? Strongly configured? Annotations?  If EF has an issue, it is too many approaches make it impossible to say the "right way" to do something)
- NHibernate
- Noticed some others in NuGet, might be worth trying them, particularly those on the simple, lightweight, no-cost side
