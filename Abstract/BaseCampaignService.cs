using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public abstract class BaseCampaignService
    {
        public virtual void Add()
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Kampanya silindi");
        }

        public virtual void Update()
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
