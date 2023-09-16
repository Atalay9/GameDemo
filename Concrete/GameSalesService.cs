using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GameSalesService : BaseGameSalesService
    {
        public override void In_Game_Purchase(Player player)
        {
            base.In_Game_Purchase(player);
        }

        public override void Discount(Campaign campaign)
        {
            base.Discount(campaign);
        }
    }
}
