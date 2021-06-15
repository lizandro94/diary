using MediatR;
using System;
using System.Collections.Generic;

namespace Diary.Application.Features.Diaries.Queries.GetDiariesList
{
    public class GetDiaryListQuery : IRequest<List<DiaryListVm>>
    {
        public Guid UserId { get; set; }
    }
}
