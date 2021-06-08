using Diary.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Persistence.Repositories
{
    public class DiaryRepository : BaseRepository<Domain.Entities.Diary>, IDiaryRepository
    {
        public DiaryRepository(DiaryDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Domain.Entities.Diary>> GetDiariesByUserId(Guid userId)
        {
            var diaries = await _dbContext.Diaries.Where(d => d.UserId == userId).ToListAsync();
            return diaries;
        }
    }
}
