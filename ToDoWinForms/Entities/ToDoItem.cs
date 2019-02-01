﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWinForms.Entities
{
    public class ToDoItem
    {
        public virtual int Id { get; protected set; }
        public virtual string ItemName { get; set; }
        public virtual string Description { get; set; }
        public virtual bool Completed { get; set; }

        //just use ctor(){memberinitializers} instead
        //public ToDoItem(string deviceName, string characterName, bool completedToday)
        //{
        //    this.Id = 0;
        //    this.DeviceName = deviceName;
        //    this.CharacterName = characterName;
        //    this.CompletedToday = completedToday;
        //}

        //try to skip this too
        //public ToDoItem()
        //{
        //}
    }
}

