﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dev2.Integration.Tests.Helpers;

namespace Dev2.Integration.Tests.Dev2.Application.Server.Tests.Bpm_unit_tests.Plugins
{
    [TestClass]
    [Ignore]
    public class PluginsReturningPathsFromComplexType
    {
        // Bug 7820
        [TestMethod]
        public void TestPluginsReturningPathsFromComplexType() {
            string PostData = String.Format("{0}{1}", ServerSettings.WebserverURI, "PluginsReturningPathsFromComplexType");
            string expected = @"<InterrogationResult><z:anyType xmlns:i=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:d1p1=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.Ouput"" i:type=""d1p1:OutputDescription"" xmlns:z=""http://schemas.microsoft.com/2003/10/Serialization/""><d1p1:DataSourceShapes xmlns:d2p1=""http://schemas.microsoft.com/2003/10/Serialization/Arrays""><d2p1:anyType i:type=""d1p1:DataSourceShape""><d1p1:Paths><d2p1:anyType xmlns:d5p1=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.Poco"" i:type=""d5p1:PocoPath""><ActualPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Name</ActualPath><DisplayPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Name</DisplayPath><OutputExpression xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"" /><SampleData xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Dev2</SampleData></d2p1:anyType><d2p1:anyType xmlns:d5p1=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.Poco"" i:type=""d5p1:PocoPath""><ActualPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments.Capacity</ActualPath><DisplayPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments.Capacity</DisplayPath><OutputExpression xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"" /><SampleData xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">4</SampleData></d2p1:anyType><d2p1:anyType xmlns:d5p1=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.Poco"" i:type=""d5p1:PocoPath""><ActualPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments.Count</ActualPath><DisplayPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments.Count</DisplayPath><OutputExpression xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"" /><SampleData xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">2</SampleData></d2p1:anyType><d2p1:anyType xmlns:d5p1=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.Poco"" i:type=""d5p1:PocoPath""><ActualPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments().Name</ActualPath><DisplayPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments().Name</DisplayPath><OutputExpression xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"" /><SampleData xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Dev,Accounts</SampleData></d2p1:anyType><d2p1:anyType xmlns:d5p1=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.Poco"" i:type=""d5p1:PocoPath""><ActualPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments().Employees.Capacity</ActualPath><DisplayPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments().Employees.Capacity</DisplayPath><OutputExpression xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"" /><SampleData xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">4,4</SampleData></d2p1:anyType><d2p1:anyType xmlns:d5p1=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.Poco"" i:type=""d5p1:PocoPath""><ActualPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments().Employees.Count</ActualPath><DisplayPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments().Employees.Count</DisplayPath><OutputExpression xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"" /><SampleData xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">2,2</SampleData></d2p1:anyType><d2p1:anyType xmlns:d5p1=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph.Poco"" i:type=""d5p1:PocoPath""><ActualPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments().Employees().Name</ActualPath><DisplayPath xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Departments.Employees().Name</DisplayPath><OutputExpression xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"" /><SampleData xmlns=""http://schemas.datacontract.org/2004/07/Unlimited.Framework.Converters.Graph"">Brendon,Jayd,Bob,Jo</SampleData></d2p1:anyType></d1p1:Paths></d2p1:anyType></d1p1:DataSourceShapes><d1p1:Format>ShapedXML</d1p1:Format></z:anyType></InterrogationResult>";

            string ResponseData = TestHelper.PostDataToWebserver(PostData);

            StringAssert.Contains(ResponseData, expected);
        }
    }
}
