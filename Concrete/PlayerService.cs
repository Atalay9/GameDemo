using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class PlayerService : BasePlayerService
    {
        IPlayerCheckService _playerCheckService;

        public PlayerService(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Register(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Register(player);
            }
            else
            {
                Console.WriteLine("Not a valid person!");
            }
        }
    }
}
