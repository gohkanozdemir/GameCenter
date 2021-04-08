using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Services
{
    public interface IGameService
    {
        void Save(Game game);
        void Update(Game game);
        void Delete(Game game);
        List<Game> GetAll();
        Game GetById(int id);
        Game GetByName(String name);
    }
}
