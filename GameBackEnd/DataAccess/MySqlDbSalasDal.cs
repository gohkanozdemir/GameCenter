using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.DataAccess
{
    class MySqlDbSalasDal : ISalesDal
    {
        public void Delete(Sales sales)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan " + sales.Id + " silindi.");
        }

        public List<Game> GetMyGames(int id)
        {
            List<Game> games = new List<Game>();
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan Player a ait game listesi gonderildi.");
            return games;
        }

        public void Save(Sales sales)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabaninn " + sales.Id + " eklendi.");
        }

        public void Update(Sales sales)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindaki " + sales.Id + " guncellendi.");
        }
    }
}
