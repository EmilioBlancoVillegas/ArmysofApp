using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArmySOF.Classes
{
    public class Game
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
    }
}
