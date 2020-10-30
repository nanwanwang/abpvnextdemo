﻿using Volo.Abp.Application.Dtos;

namespace Demon.BookStore.Authors
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}