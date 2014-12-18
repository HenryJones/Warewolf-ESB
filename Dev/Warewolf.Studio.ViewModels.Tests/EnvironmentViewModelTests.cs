﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dev2.Common.Interfaces;
using Dev2.Common.Interfaces.Data;
using Dev2.Common.Interfaces.Studio.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Warewolf.Studio.ViewModels.Tests
{
    [TestClass]
    public class EnvironmentViewModelTests
    {
        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("EnvironmentViewModel_Constructor")]
        public void EnvironmentViewModel_Constructor_ServerPassedIn_ShouldSetServerProperty()
        {
            //------------Setup for test--------------------------
            var server = new Mock<IServer>();
            
            //------------Execute Test---------------------------
            IEnvironmentViewModel environmentViewModel = new EnvironmentViewModel(server.Object);
            //------------Assert Results-------------------------
            Assert.IsNotNull(environmentViewModel);
            Assert.IsNotNull(environmentViewModel.Server);
        }

        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("EnvironmentViewModel_Constructor")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EnvironmentViewModel_Constructor_NullServer_ArgumentNullException()
        {
            //------------Setup for test--------------------------
            
            
            //------------Execute Test---------------------------
            new EnvironmentViewModel(null);
            //------------Assert Results-------------------------
        }

        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("EnvironmentViewModel_Connect")]
        public void EnvironmentViewModel_Connect_ShouldCallConnectOnEnvironment()
        {
            //------------Setup for test--------------------------
            var server = new Mock<IServer>();
            server.Setup(server1 => server1.Connect()).Returns(false);
            var environmentViewModel = new EnvironmentViewModel(server.Object);
            
            //------------Execute Test---------------------------
            environmentViewModel.Connect();
            //------------Assert Results-------------------------
            server.Verify();
            Assert.IsFalse(environmentViewModel.IsConnected);
        }

        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("EnvironmentViewModel_Connect")]
        public void EnvironmentViewModel_Connect_WhenServerDoesConnect_ShouldBeConnected()
        {
            //------------Setup for test--------------------------
            var server = new Mock<IServer>();
            server.Setup(server1 => server1.Connect()).Returns(true).Verifiable();
            var environmentViewModel = new EnvironmentViewModel(server.Object);
            
            //------------Execute Test---------------------------
            environmentViewModel.Connect();
            //------------Assert Results-------------------------
            server.Verify();
            Assert.IsTrue(environmentViewModel.IsConnected);
        }

        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("EnvironmentViewModel_Load")]
        public void EnvironmentViewModel_Load_WhenServerNotConnected_ShouldNotLoadResources()
        {
            //------------Setup for test--------------------------
            var server = new Mock<IServer>();
            server.Setup(server1 => server1.Load()).Returns(new List<IResource>()).Verifiable();
            var environmentModel = new EnvironmentViewModel(server.Object);
            
            //------------Execute Test---------------------------
            environmentModel.Load();
            //------------Assert Results-------------------------
            Assert.IsFalse(environmentModel.IsLoaded);
            server.Verify(server1 => server1.Load(),Times.Never());
        }

        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("EnvironmentViewModel_Load")]
        public void EnvironmentViewModel_Load_WhenServerConnected_ShouldLoadResourcesFromServer()
        {
            //------------Setup for test--------------------------
            var server = new Mock<IServer>();
            server.Setup(server1 => server1.Connect()).Returns(true);
            server.Setup(server1 => server1.Load()).Returns(new List<IResource>()).Verifiable();
            var environmentModel = new EnvironmentViewModel(server.Object);
            environmentModel.Connect();
            //------------Execute Test---------------------------
            environmentModel.Load();
            //------------Assert Results-------------------------
            server.Verify();
            Assert.IsTrue(environmentModel.IsLoaded);
        }

        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("EnvironmentViewModel_Load")]
        public void EnvironmentViewModel_Load_ShouldCreateExplorerItems()
        {
            //------------Setup for test--------------------------
            var resourceWithNoChildren = new Mock<IResource>();
            resourceWithNoChildren.Setup(resource => resource.Children).Returns(new List<IResource>());
            var resourceWithOneLevelChildren = new Mock<IResource>();
            resourceWithOneLevelChildren.Setup(resource => resource.Children).Returns(new List<IResource> { new Mock<IResource>().Object });
            var resourceWithMultipleLevelChildren = new Mock<IResource>();
            var resourceWithChildren = new Mock<IResource>();
            var childResource = new Mock<IResource>();
            resourceWithChildren.Setup(resource => resource.Children).Returns(new List<IResource> { childResource.Object });
            var anotherResourceAsChildren = new Mock<IResource>();
            resourceWithMultipleLevelChildren.Setup(resource => resource.Children).Returns(new List<IResource>
            {
                resourceWithChildren.Object,anotherResourceAsChildren.Object
            });
            var server = new Mock<IServer>();
            server.Setup(server1 => server1.Connect()).Returns(true);
            server.Setup(server1 => server1.Load()).Returns(new List<IResource> { resourceWithNoChildren.Object, resourceWithOneLevelChildren.Object, resourceWithMultipleLevelChildren .Object}).Verifiable();
            var environmentViewModel = new EnvironmentViewModel(server.Object);
            environmentViewModel.Connect();
            //------------Execute Test---------------------------
            environmentViewModel.Load();
            //------------Assert Results-------------------------
            Assert.IsTrue(environmentViewModel.IsLoaded);
            Assert.AreEqual(3,environmentViewModel.ExplorerItemViewModels.Count);
            Assert.AreEqual(1,environmentViewModel.ExplorerItemViewModels.ToList()[1].Children.Count);
         }
    }
}