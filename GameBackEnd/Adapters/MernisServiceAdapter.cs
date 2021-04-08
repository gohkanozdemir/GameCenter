using GameBackEnd.Entities;
using GameBackEnd.Services;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEnd.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> response = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId),
                                                                                        player.FirstName.ToUpper(),
                                                                                        player.LastName.ToUpper(),
                                                                                        player.DateOfBirth.Year);
            response.Wait();
            return response.Result.Body.TCKimlikNoDogrulaResult;

            // return true;  Hizli Test icin acilabilir
        }
    }
}
