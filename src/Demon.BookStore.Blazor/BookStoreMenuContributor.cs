using System.Threading.Tasks;
using Demon.BookStore.Localization;
using Demon.BookStore.Permissions;
using Volo.Abp.UI.Navigation;

namespace Demon.BookStore.Blazor
{
    public class BookStoreMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
              return;
            }

            var l = context.GetLocalizer<BookStoreResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "BookStore.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );
            // context.Menu.AddItem(new ApplicationMenuItem(
            //     "BooksStore",
            //     l["Menu:BookStore"],
            //     icon: "fa fa-book"
            // )).AddItem(new ApplicationMenuItem(
            //     "BooksStore.Books",
            //     l["Menu:Books"],
            //     url: "/books"
            // ));
            
            var bookStoreMenu = new ApplicationMenuItem(
                "BooksStore",
                l["Menu:BookStore"],
                icon: "fa fa-book"
            );

            context.Menu.AddItem(bookStoreMenu);
            if (await context.IsGrantedAsync(BookStorePermissions.Books.Default))
            {
                bookStoreMenu.AddItem(new ApplicationMenuItem(
                    "BooksStore.Books",
                    l["Menu:Books"],
                    url: "/books"
                ));
            }

        }
    }
}
