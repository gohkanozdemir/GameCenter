using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.DataAccess
{
    class MySqlDbGameDal : IGameDal
    {
        public void Delete(Game game)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan " + game.GameName + " silindi.");
        }

        public List<Game> GetAll()
        {
            List<Game> games = new List<Game>();
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan game listesi gonderildi.");
            return games;
        }

        public Game GetById(int id)
        {
            Game game = new Game();
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan" + id + " numarali game gonderildi.");
            return game;
        }

        public Game GetByName(string name)
        {
            Game game = new Game();
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan" + name + " isimli game gonderildi.");
            return game;
        }

        public void Save(Game game)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanina " + game.GameName + " eklendi.");
        }

        public void Update(Game game)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabaninda " + game.GameName + " guncellendi.");
        }
    }
}
