using AutoMapper;
using Diary.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Diary.Application.Features.Diaries.Queries.GetDiariesList
{
    public class GetDiaryListQueryHandler : IRequestHandler<GetDiaryListQuery, List<DiaryListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IDiaryRepository _diaryRepository;

        public GetDiaryListQueryHandler(IMapper mapper, IDiaryRepository diaryRepository)
        {
            _mapper = mapper;
            _diaryRepository = diaryRepository;
        }

        public async Task<List<DiaryListVm>> Handle(GetDiaryListQuery request, CancellationToken cancellationToken)
        {
            var diaries = (await _diaryRepository.GetDiariesByUserId(request.UserId)).OrderBy(d => d.Name);
            return _mapper.Map<List<DiaryListVm>>(diaries);
        }
    }
}
