using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.DataAccess
{
    public class MySqlCampaignAssociatedDal : ICampaignAssociatedDal
    {

        public List<Game> GetCampaignGames()
        {
            List<Game> games = new List<Game>();
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan oyunlarda a ait indirimler listesi gonderildi.");
            return games;
        }

        public void Save(int CampaignId, int GameId)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanina "+ GameId + "nolu oyuna "+ CampaignId + " nolu kampanya tanimlandi.");
        }
    }
}
