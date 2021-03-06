using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Services
{
    public interface ICampaignAssociatedService
    {
        void Save(int CampaignId, int GameId);
        List<Game> GetCampaignGames();
    }
}
