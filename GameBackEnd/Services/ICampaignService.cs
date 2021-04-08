using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Services
{
    public interface ICampaignService
    {
        void Save(Campaign campaign);
        void Save(List<Campaign> campaigns);
        void Update(Campaign campaign);
        void Update(List<Campaign> campaigns);
        void Delete(Campaign campaign);
        void Delete(List<Campaign> campaigns);
    }
}
