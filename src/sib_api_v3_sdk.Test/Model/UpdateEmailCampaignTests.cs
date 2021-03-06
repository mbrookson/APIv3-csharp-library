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
    ///  Class for testing UpdateEmailCampaign
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UpdateEmailCampaignTests
    {
        // TODO uncomment below to declare an instance variable for UpdateEmailCampaign
        //private UpdateEmailCampaign instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UpdateEmailCampaign
            //instance = new UpdateEmailCampaign();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UpdateEmailCampaign
        /// </summary>
        [Test]
        public void UpdateEmailCampaignInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpdateEmailCampaign
            //Assert.IsInstanceOfType<UpdateEmailCampaign> (instance, "variable 'instance' is a UpdateEmailCampaign");
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
        /// Test the property 'Sender'
        /// </summary>
        [Test]
        public void SenderTest()
        {
            // TODO unit test for the property 'Sender'
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
        /// Test the property 'HtmlContent'
        /// </summary>
        [Test]
        public void HtmlContentTest()
        {
            // TODO unit test for the property 'HtmlContent'
        }
        /// <summary>
        /// Test the property 'HtmlUrl'
        /// </summary>
        [Test]
        public void HtmlUrlTest()
        {
            // TODO unit test for the property 'HtmlUrl'
        }
        /// <summary>
        /// Test the property 'ScheduledAt'
        /// </summary>
        [Test]
        public void ScheduledAtTest()
        {
            // TODO unit test for the property 'ScheduledAt'
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
        /// Test the property 'Recipients'
        /// </summary>
        [Test]
        public void RecipientsTest()
        {
            // TODO unit test for the property 'Recipients'
        }
        /// <summary>
        /// Test the property 'AttachmentUrl'
        /// </summary>
        [Test]
        public void AttachmentUrlTest()
        {
            // TODO unit test for the property 'AttachmentUrl'
        }
        /// <summary>
        /// Test the property 'InlineImageActivation'
        /// </summary>
        [Test]
        public void InlineImageActivationTest()
        {
            // TODO unit test for the property 'InlineImageActivation'
        }
        /// <summary>
        /// Test the property 'MirrorActive'
        /// </summary>
        [Test]
        public void MirrorActiveTest()
        {
            // TODO unit test for the property 'MirrorActive'
        }
        /// <summary>
        /// Test the property 'Recurring'
        /// </summary>
        [Test]
        public void RecurringTest()
        {
            // TODO unit test for the property 'Recurring'
        }
        /// <summary>
        /// Test the property 'Footer'
        /// </summary>
        [Test]
        public void FooterTest()
        {
            // TODO unit test for the property 'Footer'
        }
        /// <summary>
        /// Test the property 'Header'
        /// </summary>
        [Test]
        public void HeaderTest()
        {
            // TODO unit test for the property 'Header'
        }
        /// <summary>
        /// Test the property 'UtmCampaign'
        /// </summary>
        [Test]
        public void UtmCampaignTest()
        {
            // TODO unit test for the property 'UtmCampaign'
        }
        /// <summary>
        /// Test the property 'Params'
        /// </summary>
        [Test]
        public void ParamsTest()
        {
            // TODO unit test for the property 'Params'
        }
        /// <summary>
        /// Test the property 'SendAtBestTime'
        /// </summary>
        [Test]
        public void SendAtBestTimeTest()
        {
            // TODO unit test for the property 'SendAtBestTime'
        }
        /// <summary>
        /// Test the property 'AbTesting'
        /// </summary>
        [Test]
        public void AbTestingTest()
        {
            // TODO unit test for the property 'AbTesting'
        }
        /// <summary>
        /// Test the property 'SubjectA'
        /// </summary>
        [Test]
        public void SubjectATest()
        {
            // TODO unit test for the property 'SubjectA'
        }
        /// <summary>
        /// Test the property 'SubjectB'
        /// </summary>
        [Test]
        public void SubjectBTest()
        {
            // TODO unit test for the property 'SubjectB'
        }
        /// <summary>
        /// Test the property 'SplitRule'
        /// </summary>
        [Test]
        public void SplitRuleTest()
        {
            // TODO unit test for the property 'SplitRule'
        }
        /// <summary>
        /// Test the property 'WinnerCriteria'
        /// </summary>
        [Test]
        public void WinnerCriteriaTest()
        {
            // TODO unit test for the property 'WinnerCriteria'
        }
        /// <summary>
        /// Test the property 'WinnerDelay'
        /// </summary>
        [Test]
        public void WinnerDelayTest()
        {
            // TODO unit test for the property 'WinnerDelay'
        }

    }

}
