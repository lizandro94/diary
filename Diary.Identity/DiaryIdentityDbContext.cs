using Diary.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Diary.Identity
{
    public class DiaryIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public DiaryIdentityDbContext(DbContextOptions<DiaryIdentityDbContext> options) : base(options)
        {
        }
    }
}
