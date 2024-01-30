using ShoppingCart.DataAccess.Data;

namespace ShoppingCart.DataAccess.Repositories
{
    public class ApplicationUserRepository : IApplicationUser
    {
        public ApplicationUserRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public ApplicationDbContext Context { get; }
    }
}