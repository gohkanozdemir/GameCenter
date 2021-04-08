using GameBackEnd.Entities;
using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    public class CampaignManager : ICampaignService
    {
        private ICampaignDal _campaignDal;
        private ILoggerService _loggerService;

        public CampaignManager(ICampaignDal campaignDal, ILoggerService loggerService)
        {
            _campaignDal = campaignDal;
            _loggerService = loggerService;
        }

        public void Delete(Campaign campaign)
        {
            // Transactional islemleri ve kontroller
            _campaignDal.Delete(campaign);
            _loggerService.Log();
        }
        public void Delete(List<Campaign> campaigns)
        {
            // Transactional islemleri ve kontroller
            _campaignDal.Delete(campaigns);
            _loggerService.Log();
        }

        public void Save(Campaign campaign)
        {
            // Transactional islemleri ve kontroller
            _campaignDal.Save(campaign);
            _loggerService.Log();
        }
        public void Save(List<Campaign> campaigns)
        {
            // Transactional islemleri ve kontroller
            _campaignDal.Save(campaigns);
            _loggerService.Log();
        }

        public void Update(Campaign campaign)
        {
            // Transactional islemleri ve kontroller
            _campaignDal.Update(campaign);
            _loggerService.Log();
        }
        public void Update(List<Campaign> campaigns)
        {
            // Transactional islemleri ve kontroller
            _campaignDal.Update(campaigns);
            _loggerService.Log();
        }
    }
}
