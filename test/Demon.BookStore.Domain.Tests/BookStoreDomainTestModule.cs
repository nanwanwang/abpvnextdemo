using Demon.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Demon.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}