using asprule1020.DataAccess.Data;
using asprule1020.Models;
using asprule1020.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;

        public DbInitializer(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }

        public void Initialize()
        {
            // migrations if they are not applied
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }

            }
            catch (Exception ex)
            {
            }
            // create roles - Admin, Evaluator, Client, Region Focal
            if (!_roleManager.RoleExistsAsync(SD.Role_Client).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Client)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Evaluator)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Region_Focal)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Po_Head)).GetAwaiter().GetResult();
            }
            //if roles are not created, then we will create admin user as well

            const string adminEmail = "remarkrobas@gmail.com";
            var created = _userManager.CreateAsync(new ApplicationUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                FirstName = "Remark",
                MiddleName = "Acuesta",
                LastName = "Robas",
                EstProvince = "Rizal",
                Role = SD.Role_Admin
            }, "Admin@02").GetAwaiter().GetResult();

            var user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == adminEmail);
            _userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();
            return;

        }
    }
}
