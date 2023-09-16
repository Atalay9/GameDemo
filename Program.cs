using GameDemo.Abstract;
using System;
using System.Threading.Channels;
using System.Threading.Tasks;
using E_Devlet_Service_Reference;
using GameDemo.Adapters;
using GameDemo.Entities;
using GameDemo.Concrete;

namespace GameDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            BasePlayerService playerService = new Concrete.PlayerService(new E_Devlet_Service_Adapter());
            Player player1 = new Player()
            {
                UserName = "username1",
                Password = "password",
                MailAddress = "player@player.com",
                Nickname = "morphy",
                FirstName = "Atalay",
                LastName = "Yılmazşimşek",
                NationalityId = "15427240656",
                DateOfBirth = new DateTime(1999,05,24)

            };

            playerService.Register(player1);

            BaseGameSalesService gameService = new GameSalesService();
            BaseCampaignService campaignService = new CampaignService();


            gameService.In_Game_Purchase(player1);
            campaignService.Add();
            gameService.Discount(new Campaign { CampaignName = "Kış indirimleri"});
            
        }
    }
}