using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Diary.Application.Contracts.Persistence
{
    public interface IDiaryRepository : IAsyncRepository<Domain.Entities.Diary>
    {
        Task<List<Domain.Entities.Diary>> GetDiariesByUserId(Guid userId);
    }
}
