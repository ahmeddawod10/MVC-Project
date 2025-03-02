using Serenity.Navigation;
using MyPages = AdminPanel.Conne.Pages;

[assembly: NavigationLink(int.MaxValue, "Conne/Cart", typeof(MyPages.CartPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Conne/Category", typeof(MyPages.CategoryPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Conne/Product", typeof(MyPages.ProductPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Conne/Review", typeof(MyPages.ReviewPage), icon: null)]