﻿using AspNetCoreApi.Models.Common;
using AspNetCoreApi.Models.Dto;
using AspNetCoreApi.Service.Contracts;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreApi.Api.Controllers
{
    [Authorize(Roles = Role.User)]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : BaseController
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService, IMapper mapper)
            : base(mapper)
        {
            this.bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> Get()
        {
            return Ok(mapper.Map<IEnumerable<BookDto>>(await bookService.GetAll()));
        }
    }
}