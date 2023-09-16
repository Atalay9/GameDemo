using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public abstract class BasePlayerService 
    {
        public virtual void Register(Player player)
        {
            Console.WriteLine("Kayıt olma işlemi başarılı: " + player.Nickname);
        }

        public virtual void Update(Player player)
        {
            Console.WriteLine("Güncelleme işlemi başarılı: " + player.Nickname);
        }

        public virtual void Delete(Player player)
        {
            Console.WriteLine("Silme işlemi başarılı: " + player.Nickname);
        }
    }
}
