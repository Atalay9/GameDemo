using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public abstract class BaseGameSalesService : IGameSalesService
    {
        public virtual void In_Game_Purchase(Player player)
        {
            Console.WriteLine("Satın alma işlemi başarılı: " + player.Nickname);
        }
        public virtual void Discount(Campaign campaign)
        {
            Console.WriteLine("Bu kampanyadan indirim kazandınız: " + campaign.CampaignName);
        }
    }
}
