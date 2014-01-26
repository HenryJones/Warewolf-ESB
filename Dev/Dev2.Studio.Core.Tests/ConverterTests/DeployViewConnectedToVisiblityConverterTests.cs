﻿using System.Windows;
using Caliburn.Micro;
using Dev2.Providers.Events;
using Dev2.Studio.Core.AppResources.Converters;
using Dev2.Studio.Core.Interfaces;
using Dev2.Studio.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Moq;

namespace Dev2.Core.Tests.ConverterTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class DeployViewConnectedToVisiblityConverterTest
    {
        [TestMethod]
        [Owner("Jurie Smit")]
        [TestCategory("DeployViewConnectedToVisiblityConverter")]
        public void DeployViewConnectedToVisiblityConverter_Convert_IsConnectedIsFalse_VisibilityIsCollapsed()
        {
            //Arrange
            var converter = new DeployViewConnectedToVisiblityConverter();
            Mock<IEnvironmentConnection> mockEnvironmentConnection = new Mock<IEnvironmentConnection>();
            mockEnvironmentConnection.Setup(m => m.ServerEvents).Returns(new Mock<IEventPublisher>().Object);
            mockEnvironmentConnection.Setup(m => m.IsConnected).Returns(false);
            IEnvironmentModel environmentModel = new EnvironmentModel(new Mock<IEventAggregator>().Object, Guid.NewGuid(), mockEnvironmentConnection.Object);
           
            //Act
            var actual = (Visibility)converter.Convert(environmentModel, typeof(bool), null, null);
            //Assert
            Assert.AreEqual(Visibility.Collapsed, actual);
        }

        [TestMethod]
        [Owner("Jurie Smit")]
        [TestCategory("DeployViewConnectedToVisiblityConverter")]
        public void DeployViewConnectedToVisiblityConverter_Convert_IsConnectedIsTrue_VisibilityIsCollapsed()
        {
            //Arrange
            var converter = new DeployViewConnectedToVisiblityConverter();
            Mock<IEnvironmentConnection> mockEnvironmentConnection = new Mock<IEnvironmentConnection>();
            mockEnvironmentConnection.Setup(m => m.ServerEvents).Returns(new Mock<IEventPublisher>().Object);
            mockEnvironmentConnection.Setup(m => m.IsConnected).Returns(true);
            IEnvironmentModel environmentModel = new EnvironmentModel(new Mock<IEventAggregator>().Object, Guid.NewGuid(), mockEnvironmentConnection.Object);

            //Act
            var actual = (Visibility)converter.Convert(environmentModel, typeof(bool), null, null);
            //Assert
            Assert.AreEqual(Visibility.Visible, actual);
        }

        [TestMethod]
        [Owner("Jurie Smit")]
        [TestCategory("DeployViewConnectedToVisiblityConverter")]
        public void DeployViewConnectedToVisiblityConverter_Convert_EnvironmentModelIsNull_VisibilityIsCollapsed()
        {
            //Arrange
            var converter = new DeployViewConnectedToVisiblityConverter();
            //Act
            var actual = (Visibility)converter.Convert(null, typeof(bool), null, null);
            //Assert
            Assert.AreEqual(Visibility.Collapsed, actual);
        }
    }
}