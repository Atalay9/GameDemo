using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IGameSalesService
    {
        public void In_Game_Purchase(Player player);

        public void Discount(Campaign campaign);
    }
}
