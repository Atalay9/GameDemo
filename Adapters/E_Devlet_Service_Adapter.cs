using E_Devlet_Service_Reference;
using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Adapters
{
    public class E_Devlet_Service_Adapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(
                        Convert.ToInt64(player.NationalityId),
                        player.FirstName.ToUpper(),
                        player.LastName.ToUpper(),
                        player.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult; 
        }
    }
}
