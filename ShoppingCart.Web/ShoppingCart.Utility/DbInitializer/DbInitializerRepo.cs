using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShoppingCart.Utility.DbInitializer
{
    public class DbInitializerRepo : IDbInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public DbInitializerRepo(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userManager = userManager; 
            _roleManager = roleManager;
            _context = context;

        }

        public void Initializer()
        {
            try
            {
                if(_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch(Exception)
            {
                throw;

            }


            if (!_roleManager.RoleExistsAsync(WebSiteRole.Role_Admin).GetAwait) ;
        }

        
    }
}
