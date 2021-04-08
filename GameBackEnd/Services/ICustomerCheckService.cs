using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Services
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Player player);
    }
}
