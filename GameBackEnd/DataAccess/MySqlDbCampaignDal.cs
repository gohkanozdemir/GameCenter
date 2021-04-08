using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.DataAccess
{
    class MySqlDbCampaignDal : ICampaignDal
    {
        public void Delete(Campaign campaign)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindan " + campaign.CampaignName + " silindi.");
        }
        public void Delete(List<Campaign> campaigns)
        {
            // Veritabani islemleri....
            foreach (Campaign campaign in campaigns)
            {
                Console.WriteLine("Mysql veritabanindan " + campaign.CampaignName + " silindi.");
            }            
        }

        public void Save(Campaign campaign)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanina " + campaign.CampaignName + " kaydedildi.");
        }
        public void Save(List<Campaign> campaigns)
        {
            // Veritabani islemleri....
            foreach (Campaign campaign in campaigns)
            {
                Console.WriteLine("Mysql veritabanina " + campaign.CampaignName + " kaydedildi.");
            }            
        }

        public void Update(Campaign campaign)
        {
            // Veritabani islemleri....
            Console.WriteLine("Mysql veritabanindaki " + campaign.CampaignName + " guncellendi.");
        }
        public void Update(List<Campaign> campaigns)
        {
            // Veritabani islemleri....
            foreach (Campaign campaign in campaigns)
            {
                Console.WriteLine("Mysql veritabanindaki " + campaign.CampaignName + " guncellendi.");
            }
        }
    }
}
