using Microsoft.AspNetCore.Identity;
using System;

namespace StockManagementSystem.Entities

{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
