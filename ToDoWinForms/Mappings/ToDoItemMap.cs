using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NHibernate.Mapping;
//using FluentNHibernate.Mapping;
using ToDoWinForms.Entities;

//exclude from project - this is for NHibernate version

namespace ToDoWinForms.Mappings
{
    public class ToDoItemMap : ClassMap<DailyItem>
    {
        public ToDoItemMap()
        {
            Id(x => x.Id);
            Map(x => x.DeviceName);
            Map(x => x.CharacterName);
            Map(x => x.CompletedToday);
            //References(x => x.Store);
        }
    }
}







