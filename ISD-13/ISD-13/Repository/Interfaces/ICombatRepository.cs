﻿using ISD_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    public interface ICombatRepository : IRepository<Combat>
    {
        List<Combat> FindCombatsByUserLogin(string login);
        void SaveEdit(List<Combat> combatList);
    }
}
