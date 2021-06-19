using Diary.Application.Contracts.Persistence;
using Diary.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Diary.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DiaryDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DiaryConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IDiaryRepository, DiaryRepository>();

            return services;
        }
    }
}
