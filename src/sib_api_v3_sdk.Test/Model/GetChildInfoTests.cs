/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Model;
using sib_api_v3_sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace sib_api_v3_sdk.Test
{
    /// <summary>
    ///  Class for testing GetChildInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetChildInfoTests
    {
        // TODO uncomment below to declare an instance variable for GetChildInfo
        //private GetChildInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetChildInfo
            //instance = new GetChildInfo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetChildInfo
        /// </summary>
        [Test]
        public void GetChildInfoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetChildInfo
            //Assert.IsInstanceOfType<GetChildInfo> (instance, "variable 'instance' is a GetChildInfo");
        }


        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Test]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Test]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }
        /// <summary>
        /// Test the property 'CompanyName'
        /// </summary>
        [Test]
        public void CompanyNameTest()
        {
            // TODO unit test for the property 'CompanyName'
        }
        /// <summary>
        /// Test the property 'Credits'
        /// </summary>
        [Test]
        public void CreditsTest()
        {
            // TODO unit test for the property 'Credits'
        }
        /// <summary>
        /// Test the property 'Statistics'
        /// </summary>
        [Test]
        public void StatisticsTest()
        {
            // TODO unit test for the property 'Statistics'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'Ips'
        /// </summary>
        [Test]
        public void IpsTest()
        {
            // TODO unit test for the property 'Ips'
        }
        /// <summary>
        /// Test the property 'ApiKeys'
        /// </summary>
        [Test]
        public void ApiKeysTest()
        {
            // TODO unit test for the property 'ApiKeys'
        }

    }

}
