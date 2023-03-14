using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Mission09_adw97.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mission09_adw97.Models
{
    public class SessionBasket : Basket
    {
        //This block checks to see if there is already an existing basket in the session. If there is, it brings that one in. Otherwise, it creates a new basket
        public static Basket GetBasket(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionBasket basket = session?.GetJson<SessionBasket>("Basket") ?? new SessionBasket();

            basket.Session = session;

            return basket;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Books book, int qty)
        {
            base.AddItem(book, qty);
            Session.SetJson("Basket", this);
        }

        public override void RemoveItem(Books book)
        {
            base.RemoveItem(book);
            Session.SetJson("Basket", this);
        }

        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.Remove("Basket");
        }
    }
}
