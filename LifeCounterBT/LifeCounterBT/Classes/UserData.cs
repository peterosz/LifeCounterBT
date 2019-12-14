using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeCounterBT.Classes
{
    [Table("UserData")]
    public class UserData
    {
        public string Name { get; set; }
    }
}
