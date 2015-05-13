﻿
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Diagnostics.CodeAnalysis;
using Dev2.DynamicServices;
using Dev2.Providers.Validation.Rules;
using Dev2.TO;
using Dev2.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unlimited.Applications.BusinessDesignStudio.Activities;

// ReSharper disable InconsistentNaming
namespace Dev2.Tests.Activities.TOTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class JsonMappingCompoundTests
    {
        [TestMethod]
        [Owner("Kerneels Roos")]
        [TestCategory("FindJsonMappingCompoundToConstructor")]
        public void JsonMappingCompoundTo_Constructor_SetsProperties_NotIsCompound()
        {
            //------------Setup for test--------------------------
            var dataObject = new DsfDataObject(xmldata: string.Empty, dataListId: Guid.NewGuid());
            dataObject.Environment.Assign("[[a]]", "10");
            dataObject.Environment.Assign("[[b]]", "20");
            dataObject.Environment.Assign("[[rec(1).a]]", "50");
            dataObject.Environment.Assign("[[rec(1).b]]", "500");
            //------------Execute Test---------------------------

            var jsonMappingCompound = new JsonMappingCompoundTo(
                env: dataObject.Environment,
                compound: new JsonMappingTo { SourceName = "[[a]]", DestinationName = "a" }
            );
            //------------Assert Results-------------------------
            Assert.IsNotNull(jsonMappingCompound);
            Assert.IsFalse(jsonMappingCompound.IsCompound);
        }
        [TestMethod]
        [Owner("Kerneels Roos")]
        [TestCategory("FindJsonMappingCompoundToConstructor")]
        public void JsonMappingCompoundTo_Constructor_SetsProperties_IsCompound()
        {
            //------------Setup for test--------------------------
            var dataObject = new DsfDataObject(xmldata: string.Empty, dataListId: Guid.NewGuid());
            dataObject.Environment.Assign("[[a]]", "10");
            dataObject.Environment.Assign("[[b]]", "20");
            dataObject.Environment.Assign("[[rec(1).a]]", "50");
            dataObject.Environment.Assign("[[rec(1).b]]", "500");
            //------------Execute Test---------------------------

            var jsonMappingCompound = new JsonMappingCompoundTo(
                env: dataObject.Environment,
                compound: new JsonMappingTo
                {
                    SourceName = "[[a]],[[b]]",
                    DestinationName = "myName"
                }
            );
            //------------Assert Results-------------------------
            Assert.IsNotNull(jsonMappingCompound);
            Assert.IsTrue(jsonMappingCompound.IsCompound);
        }
    }
}
