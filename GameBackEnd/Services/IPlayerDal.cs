using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Services
{
    public interface IPlayerDal
    {
        void Save(Player player);
        void Update(Player player);
        void Delete(Player player);
        List<Player> GetAll();
        Player GetById(int id);
        Player GetByName(String name);

    }
}
