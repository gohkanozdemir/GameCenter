using GameBackEnd.Adapters;
using GameBackEnd.Concretes;
using GameBackEnd.DataAccess;
using GameBackEnd.Entities;
using GameBackEnd.Utils;
using System;
using System.Collections.Generic;

namespace GameBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oyuncu Profili islemleri
            Console.WriteLine("**************  Oyuncu Profili islemleri *********************");
            Player player1 = new Player { Id = 1, FirstName = "Gökhan", LastName = "özdemir", DateOfBirth = new DateTime(1987, 11, 24), NationalityId = "11122250888" };
            Player player2 = new Player { Id = 2, FirstName = "Ayhan", LastName = "özdemir", DateOfBirth = new DateTime(1988, 12, 30), NationalityId = "11122250777" };
            Player player3 = new Player { Id = 2, FirstName = "Hikmet", LastName = "özdemir", DateOfBirth = new DateTime(1989, 07, 21), NationalityId = "11122250999" };

            PlayerManager playerManager = new PlayerManager(new MySqlDbPlayerDal(), new MernisServiceAdapter(), new FileLoggerManager());
            playerManager.Save(player1);
            playerManager.Save(player2);
            player1.LastName = "Ozdemir";
            playerManager.Update(player1);
            playerManager.Delete(player3);


            // Kampanya tanimlama islemleri
            Console.WriteLine("\n**************  Kampanya tanimlama islemleri   *********************");
            Campaign campaign1 = new Campaign
            {
                Id = 1,
                CampaignName = "ISKONTO20",
                CapmpaignDiscountRate = 20,
                Description = "yuzde 20 iskonto kampanyasi",
                StartDate = new DateTime(2021, 04, 09),
                EndDate = new DateTime(2021, 04, 24),
                IsActive = 1
            };

            Campaign campaign2 = new Campaign
            {
                Id = 2,
                CampaignName = "ISKONTO50",
                CapmpaignDiscountRate = 50,
                Description = "yuzde 50 iskonto kampanyasi",
                StartDate = new DateTime(2021, 07, 01),
                EndDate = new DateTime(2021, 07, 05),
                IsActive = 0
            };
            Campaign campaign3 = new Campaign
            {
                Id = 3,
                CampaignName = "ISKONTO100",
                CapmpaignDiscountRate = 100,
                Description = "yuzde 100 iskonto kampanyasi",
                StartDate = new DateTime(2021, 12, 31),
                EndDate = new DateTime(2021, 12, 31),
                IsActive = 0
            };
            List<Campaign> campaignList = new List<Campaign> { campaign2, campaign3 };
            CampaignManager campaignManager = new CampaignManager(new MySqlDbCampaignDal(), new FileLoggerManager());
            campaignManager.Save(campaign1);
            campaignManager.Save(campaignList);
            campaign1.IsActive = 0;
            campaign1.ModifiedDate = new DateTime(2021, 07, 05);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign2);

            // Oyun tanimlama islemleri
            Console.WriteLine("\n**************  Oyun tanimlama islemleri   *********************");
            Game game1 = new Game { Id = 1, GameName = "Oyun1", GameUnitPrice = 150 };
            Game game2 = new Game { Id = 2, GameName = "Oyun2", GameUnitPrice = 250 };
            Game game3 = new Game { Id = 3, GameName = "Oyun3", GameUnitPrice = 350 };

            GameManager gameManager = new GameManager(new MySqlDbGameDal(), new FileLoggerManager());
            gameManager.Save(game1);
            gameManager.Save(game2);
            gameManager.Save(game3);
            game1.GameUnitPrice = 180;
            gameManager.Update(game1);
            gameManager.Delete(game3);

            // Oyuna Kampanya tanimlama islemleri
            Console.WriteLine("\n**************  Oyuna Kampanya tanimlama islemleri  *********************");
            CampaignAssociatedManager campaignAssociatedManager = new CampaignAssociatedManager(new MySqlCampaignAssociatedDal(), new FileLoggerManager());
            campaignAssociatedManager.Save(campaign1.Id, game1.Id);
            campaignAssociatedManager.Save(campaign2.Id, game2.Id);
            campaignAssociatedManager.Save(campaign3.Id, game3.Id);

            // Satis islemleri
            Console.WriteLine("\n**************  Oyun Satis islemleri  *********************");
            SalesManager salesManager = new SalesManager(new MySqlDbSalasDal(), new FileLoggerManager());
            Console.WriteLine("totalPrice: " + Utilities.Percentage(game1.GameUnitPrice, campaign1.CapmpaignDiscountRate));
            salesManager.Save(new Sales
            {
                Id = 1,
                CampaignId = campaign1.Id,
                GameId = game1.Id,
                PlayerId = player1.Id,
                SaleDate = new DateTime(2021, 04, 09),
                SalesUnitPrice = Utilities.Percentage(game1.GameUnitPrice, campaign1.CapmpaignDiscountRate)
            });
            salesManager.Save(new Sales
            {
                Id = 2,
                CampaignId = campaign1.Id,
                GameId = game1.Id,
                PlayerId = player2.Id,
                SaleDate = new DateTime(2021, 04, 09),
                SalesUnitPrice = Utilities.Percentage(game1.GameUnitPrice, campaign1.CapmpaignDiscountRate)
            });
        }
    }
}
