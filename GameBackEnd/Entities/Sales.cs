using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public double SalesUnitPrice { get; set; }
        public DateTime SaleDate { get; set; }

    }
}
