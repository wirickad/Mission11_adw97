using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission09_adw97.Infrastructure;
using Mission09_adw97.Models;

namespace Mission09_adw97.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public PurchaseModel(IBookstoreRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        public Basket basket { get; set; }

        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Books p = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket.AddItem(p, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Books.BookId == bookId).Books);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
