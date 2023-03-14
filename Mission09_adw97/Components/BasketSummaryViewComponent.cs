using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission09_adw97.Models;

namespace Mission09_adw97.Components
{
    public class BasketSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public BasketSummaryViewComponent(Basket b)
        {
            basket = b;
        }

        public IViewComponentResult Invoke()
        {
            return View(basket);
        }

    }

}
