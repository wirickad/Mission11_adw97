﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_adw97.Models
{
    public interface IPurchaseRepository
    {

        IQueryable<Purchase> Purchases { get; }

        void SavePurchase(Purchase purchase);
    }
}
