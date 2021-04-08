using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Services
{
    public interface ISalesService
    {
        void Save(Sales sales);
        void Update(Sales sales);
        void Delete(Sales sales);
        List<Game> GetMyGames(int id); // Player ID
    }
}
