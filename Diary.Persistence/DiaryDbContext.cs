using Diary.Application.Contracts;
using Diary.Domain.Common;
using Diary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Diary.Persistence
{
    public class DiaryDbContext : DbContext
    {
        private readonly ILoggedInUserService _loggedInUserService;

        public DiaryDbContext(DbContextOptions<DiaryDbContext> options) : base(options)
        {
        }

        public DiaryDbContext(DbContextOptions<DiaryDbContext> options, ILoggedInUserService loggedInUserService)
             : base(options)
        {
            _loggedInUserService = loggedInUserService;
        }

        public DbSet<Domain.Entities.Diary> Diaries { get; set; }
        public DbSet<Memory> Memories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DiaryDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = _loggedInUserService.UserId;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = _loggedInUserService.UserId;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
