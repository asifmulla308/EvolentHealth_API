using AutoMapper;
using EvolentHealthAPI.AutoMapper;
using EvolentHealthAPI.Controllers;
using EvolentHealthAPI.Models;
using EvolentHealthAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace EvolentHealthAPITest.Tests.ControllerTests
{
    public class ContactsControllerTest
    {
        Contact contactObject;
        public ContactsControllerTest()
        {
            contactObject = new Contact();
        }

        [Fact]
        public async void Success_ContactsController_Get()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();

            // auto mapper configuration
            var mockMapper = new MapperConfiguration(c =>
              {
                  c.AddProfile(new AutoMapperProfile());
              });

            var mapper = mockMapper.CreateMapper();
            mockContactsRepository.Setup(m => m.GetContacts()).ReturnsAsync(new List<Contact>());
            ContactsController contactsController = new ContactsController(mockContactsRepository.Object, mapper);

            // Act
            var result = await contactsController.Get();
            var okResult = result as OkObjectResult;

            //Assert
            Assert.NotNull(result);
            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public async void Success_ContactsController_GetContactsById()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();

            // auto mapper configuration
            var mockMapper = new MapperConfiguration(c =>
            {
                c.AddProfile(new AutoMapperProfile());
            });

            var mapper = mockMapper.CreateMapper();
            mockContactsRepository.Setup(m => m.GetContactsById(It.IsAny<int>())).ReturnsAsync(new List<Contact>());
            ContactsController contactsController = new ContactsController(mockContactsRepository.Object, mapper);

            // Act
            var result = await contactsController.GetContactById(It.IsAny<int>());
            var okResult = result as OkObjectResult;

            //Assert
            Assert.NotNull(result);
            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public async void Success_ContactsController_Post()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();

            // auto mapper configuration
            var mockMapper = new MapperConfiguration(c =>
            {
                c.AddProfile(new AutoMapperProfile());
            });

            var mapper = mockMapper.CreateMapper();
            mockContactsRepository.Setup(m => m.CreateContact(It.IsAny<Contact>())).ReturnsAsync(new bool());
            ContactsController contactsController = new ContactsController(mockContactsRepository.Object, mapper);

            // Act
            var result = await contactsController.Post(It.IsAny<Contact>());
            var okResult = result as OkObjectResult;

            //Assert
            Assert.NotNull(result);
            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public async void Success_ContactsController_Put()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();

            // auto mapper configuration
            var mockMapper = new MapperConfiguration(c =>
            {
                c.AddProfile(new AutoMapperProfile());
            });

            var mapper = mockMapper.CreateMapper();
            mockContactsRepository.Setup(m => m.UpdateContactsById(It.IsAny<Contact>())).ReturnsAsync(new bool());
            ContactsController contactsController = new ContactsController(mockContactsRepository.Object, mapper);

            // Act
            var result = await contactsController.Put(It.IsAny<Contact>());
            var okResult = result as OkObjectResult;

            //Assert
            Assert.NotNull(result);
            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public async void Success_ContactsController_UpdateStatus()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();

            // auto mapper configuration
            var mockMapper = new MapperConfiguration(c =>
            {
                c.AddProfile(new AutoMapperProfile());
            });

            var mapper = mockMapper.CreateMapper();
            mockContactsRepository.Setup(m => m.UpdateStatus(It.IsAny<int>(), It.IsAny<string>())).ReturnsAsync(new bool());
            ContactsController contactsController = new ContactsController(mockContactsRepository.Object, mapper);

            // Act
            var result = await contactsController.UpdateStatus(It.IsAny<int>(), It.IsAny<string>());
            var okResult = result as OkObjectResult;

            //Assert
            Assert.NotNull(result);
            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public async void Success_ContactsController_Delete()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();

            // auto mapper configuration
            var mockMapper = new MapperConfiguration(c =>
            {
                c.AddProfile(new AutoMapperProfile());
            });

            var mapper = mockMapper.CreateMapper();
            mockContactsRepository.Setup(m => m.RemoveContactsById(It.IsAny<int>())).ReturnsAsync(new bool());
            ContactsController contactsController = new ContactsController(mockContactsRepository.Object, mapper);

            // Act
            var result = await contactsController.Delete(It.IsAny<int>());
            var okResult = result as OkObjectResult;

            //Assert
            Assert.NotNull(result);
            Assert.Equal(200, okResult.StatusCode);
        }
    }
}
