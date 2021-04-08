using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.DataAccess
{
    class MySqlDbPlayerDal : IPlayerDal
    {
        public void Delete(Player player)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan " + player.FirstName + " silindi.");
        }

        public List<Player> GetAll()
        {
            List<Player> players = new List<Player>();
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan player listesi gonderildi.");
            return players;
        }

        public Player GetById(int id)
        {
            Player player = new Player();
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan" + id + " numarali Player gonderildi.");
            return player;
        }

        public Player GetByName(string name)
        {
            Player player = new Player();
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan" + name + " isimli Player gonderildi.");
            return player;
        }

        public void Save(Player player)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanina " + player.FirstName + " eklendi.");
        }

        public void Update(Player player)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindaki " + player.FirstName + " guncellendi.");
        }
    }
}
