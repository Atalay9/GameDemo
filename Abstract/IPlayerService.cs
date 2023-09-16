using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IPlayerService
    {
        public void Register(Player player);

        public void Update(Player player);

        public void Delete(Player player);
    }
}
