﻿using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player);          

    }
}
   

