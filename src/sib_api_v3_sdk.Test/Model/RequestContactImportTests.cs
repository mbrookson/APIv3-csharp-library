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
    ///  Class for testing RequestContactImport
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RequestContactImportTests
    {
        // TODO uncomment below to declare an instance variable for RequestContactImport
        //private RequestContactImport instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RequestContactImport
            //instance = new RequestContactImport();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RequestContactImport
        /// </summary>
        [Test]
        public void RequestContactImportInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RequestContactImport
            //Assert.IsInstanceOfType<RequestContactImport> (instance, "variable 'instance' is a RequestContactImport");
        }


        /// <summary>
        /// Test the property 'FileUrl'
        /// </summary>
        [Test]
        public void FileUrlTest()
        {
            // TODO unit test for the property 'FileUrl'
        }
        /// <summary>
        /// Test the property 'FileBody'
        /// </summary>
        [Test]
        public void FileBodyTest()
        {
            // TODO unit test for the property 'FileBody'
        }
        /// <summary>
        /// Test the property 'ListIds'
        /// </summary>
        [Test]
        public void ListIdsTest()
        {
            // TODO unit test for the property 'ListIds'
        }
        /// <summary>
        /// Test the property 'NotifyUrl'
        /// </summary>
        [Test]
        public void NotifyUrlTest()
        {
            // TODO unit test for the property 'NotifyUrl'
        }
        /// <summary>
        /// Test the property 'NewList'
        /// </summary>
        [Test]
        public void NewListTest()
        {
            // TODO unit test for the property 'NewList'
        }
        /// <summary>
        /// Test the property 'EmailBlacklist'
        /// </summary>
        [Test]
        public void EmailBlacklistTest()
        {
            // TODO unit test for the property 'EmailBlacklist'
        }
        /// <summary>
        /// Test the property 'SmsBlacklist'
        /// </summary>
        [Test]
        public void SmsBlacklistTest()
        {
            // TODO unit test for the property 'SmsBlacklist'
        }
        /// <summary>
        /// Test the property 'UpdateExistingContacts'
        /// </summary>
        [Test]
        public void UpdateExistingContactsTest()
        {
            // TODO unit test for the property 'UpdateExistingContacts'
        }
        /// <summary>
        /// Test the property 'EmptyContactsAttributes'
        /// </summary>
        [Test]
        public void EmptyContactsAttributesTest()
        {
            // TODO unit test for the property 'EmptyContactsAttributes'
        }

    }

}
