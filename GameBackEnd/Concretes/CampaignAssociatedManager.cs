using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    public class CampaignAssociatedManager : ICampaignAssociatedService
    {
        private ICampaignAssociatedDal _campaignAssociatedDal;
        private ILoggerService _loggerService;

        public CampaignAssociatedManager(ICampaignAssociatedDal campaignAssociatedDal, ILoggerService loggerService)
        {
            _campaignAssociatedDal = campaignAssociatedDal;
            _loggerService = loggerService;
        }

        public List<Game> GetCampaignGames()
        {
            // Transactional islemleri ve kontroller
            _loggerService.Log();
            return _campaignAssociatedDal.GetCampaignGames();
        }

        public void Save(int CampaignId, int GameId)
        {
            // Transactional islemleri ve kontroller
            _campaignAssociatedDal.Save(CampaignId, GameId);
            _loggerService.Log();
        }
    }
}
