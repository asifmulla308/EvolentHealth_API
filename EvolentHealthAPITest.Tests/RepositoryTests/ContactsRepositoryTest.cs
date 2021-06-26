using AutoMapper;
using EvolentHealthAPI.AutoMapper;
using EvolentHealthAPI.Controllers;
using EvolentHealthAPI.Models;
using EvolentHealthAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace EvolentHealthAPITest.Tests.RepositoryTests
{
    public class ContactsRepositoryTest
    {
        Contact contactObject;
        public ContactsRepositoryTest()
        {
            contactObject = new Contact();
        }

        [Fact]
        public void Success_ContactsController_Get()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();
            mockContactsRepository.Setup(m => m.GetContacts()).ReturnsAsync(new List<Contact>());
            mockContactsRepository.Object.GetContacts().Result.ShouldNotBeNull();
            mockContactsRepository.Verify(v => v.GetContacts(), Times.Once());
        }
        [Fact]
        public void Success_ContactsController_GetContactsById()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();
            mockContactsRepository.Setup(m => m.GetContactsById(It.IsAny<int>())).ReturnsAsync(new List<Contact>());
            mockContactsRepository.Object.GetContactsById(It.IsAny<int>()).Result.ShouldNotBeNull();
            mockContactsRepository.Verify(v => v.GetContactsById(It.IsAny<int>()), Times.Once());
        }

        [Fact]
        public void Success_ContactsController_Put()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();
            mockContactsRepository.Setup(m => m.CreateContact(It.IsAny<Contact>())).ReturnsAsync(new bool());
            mockContactsRepository.Object.CreateContact(contactObject).Result.ShouldBe(new bool());
            mockContactsRepository.Verify(v => v.CreateContact(It.IsAny<Contact>()), Times.Once());
        }

        [Fact]
        public void Success_ContactsController_Post()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();
            mockContactsRepository.Setup(m => m.UpdateContactsById(It.IsAny<Contact>())).ReturnsAsync(new bool());
            mockContactsRepository.Object.UpdateContactsById(contactObject).Result.ShouldBe(new bool());
            mockContactsRepository.Verify(v => v.UpdateContactsById(It.IsAny<Contact>()), Times.Once());
        }

        [Fact]
        public void Success_ContactsController_UpdateStatus()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();
            mockContactsRepository.Setup(m => m.UpdateStatus(It.IsAny<int>(), It.IsAny<string>())).ReturnsAsync(new bool());
            mockContactsRepository.Object.UpdateStatus(It.IsAny<int>(), It.IsAny<string>()).Result.ShouldBe(new bool());
            mockContactsRepository.Verify(v => v.UpdateStatus(It.IsAny<int>(), It.IsAny<string>()), Times.Once());
        }
        [Fact]
        public void Success_ContactsController_Delete()
        {
            var mockContactsRepository = new Mock<IContactsRepository>();
            mockContactsRepository.Setup(m => m.RemoveContactsById(It.IsAny<int>())).ReturnsAsync(new bool());
            mockContactsRepository.Object.RemoveContactsById(It.IsAny<int>()).Result.ShouldBe(new bool());
            mockContactsRepository.Verify(v => v.RemoveContactsById(It.IsAny<int>()), Times.Once());
        }
    }
}
