using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public int IsActive { get; set; }  // Active=1, Non-active=0
        public string CampaignName { get; set; }
        public string Description { get; set; }
        public double CapmpaignDiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
