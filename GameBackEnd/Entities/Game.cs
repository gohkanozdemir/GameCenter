using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GameUnitPrice { get; set; }
    }
}
