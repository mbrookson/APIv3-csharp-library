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
    ///  Class for testing GetSmtpTemplateOverview
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetSmtpTemplateOverviewTests
    {
        // TODO uncomment below to declare an instance variable for GetSmtpTemplateOverview
        //private GetSmtpTemplateOverview instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetSmtpTemplateOverview
            //instance = new GetSmtpTemplateOverview();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetSmtpTemplateOverview
        /// </summary>
        [Test]
        public void GetSmtpTemplateOverviewInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetSmtpTemplateOverview
            //Assert.IsInstanceOfType<GetSmtpTemplateOverview> (instance, "variable 'instance' is a GetSmtpTemplateOverview");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Subject'
        /// </summary>
        [Test]
        public void SubjectTest()
        {
            // TODO unit test for the property 'Subject'
        }
        /// <summary>
        /// Test the property 'IsActive'
        /// </summary>
        [Test]
        public void IsActiveTest()
        {
            // TODO unit test for the property 'IsActive'
        }
        /// <summary>
        /// Test the property 'TestSent'
        /// </summary>
        [Test]
        public void TestSentTest()
        {
            // TODO unit test for the property 'TestSent'
        }
        /// <summary>
        /// Test the property 'Sender'
        /// </summary>
        [Test]
        public void SenderTest()
        {
            // TODO unit test for the property 'Sender'
        }
        /// <summary>
        /// Test the property 'ReplyTo'
        /// </summary>
        [Test]
        public void ReplyToTest()
        {
            // TODO unit test for the property 'ReplyTo'
        }
        /// <summary>
        /// Test the property 'ToField'
        /// </summary>
        [Test]
        public void ToFieldTest()
        {
            // TODO unit test for the property 'ToField'
        }
        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Test]
        public void TagTest()
        {
            // TODO unit test for the property 'Tag'
        }
        /// <summary>
        /// Test the property 'HtmlContent'
        /// </summary>
        [Test]
        public void HtmlContentTest()
        {
            // TODO unit test for the property 'HtmlContent'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'ModifiedAt'
        /// </summary>
        [Test]
        public void ModifiedAtTest()
        {
            // TODO unit test for the property 'ModifiedAt'
        }

    }

}
