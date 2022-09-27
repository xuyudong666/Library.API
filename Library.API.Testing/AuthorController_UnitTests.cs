using AutoMapper;
using Library.API.Controllers;
using Library.API.Entities;
using Library.API.Models;
using Library.API.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Moq;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.API.Testing
{
    public class AuthorController_UnitTests
    {
        private AuthorController _authorController;
        private Mock<IDistributedCache> _mockDistributedCache;
        private Mock<ILogger<AuthorController>> _mockLogger;
        private Mock<IMapper> _mockMapper;
        private Mock<IRepositoryWrapper> _mockRepositoryWrapper;
        private Mock<IUrlHelper> _mockUrlHelper;

        public AuthorController_UnitTests()
        {
            _mockRepositoryWrapper = new Mock<IRepositoryWrapper>();
            _mockMapper = new Mock<IMapper>();
            _mockLogger = new Mock<ILogger<AuthorController>>();
            _mockDistributedCache = new Mock<IDistributedCache>();
            _mockUrlHelper = new Mock<IUrlHelper>();
            _authorController = new AuthorController(_mockRepositoryWrapper.Object,
                                                     _mockMapper.Object,
                                                     _mockLogger.Object,
                                                     _mockDistributedCache.Object);

            _authorController.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext()
            };
        }

        [Fact]
        public async Task Test_GetAllAuthors()
        {
            var author = new Author()
            {
                Id = Guid.NewGuid(),
                Name = "Author Test 1",
                Email = "author1@xxx.com",
                BirthPlace="Beijing"
            };
            var authorDto = new AuthorDto()
            {
                Id = author.Id,
                Name = author.Name,
                BirthPlace = author.BirthPlace,
                Email = author.Email,
            };
            //var authorList = new List<Author> { author,
            //        totalCount:}
        }

    }
}
