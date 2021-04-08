using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    public class CampaignAssociated : IEntity  // Hangi kampanya hangi oyuna tanimlandi
    {
        public int CampaignId { get; set; }
        public int GameId { get; set; }
    }
}
