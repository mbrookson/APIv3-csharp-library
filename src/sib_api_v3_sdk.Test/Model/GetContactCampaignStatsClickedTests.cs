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
    ///  Class for testing GetContactCampaignStatsClicked
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetContactCampaignStatsClickedTests
    {
        // TODO uncomment below to declare an instance variable for GetContactCampaignStatsClicked
        //private GetContactCampaignStatsClicked instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetContactCampaignStatsClicked
            //instance = new GetContactCampaignStatsClicked();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetContactCampaignStatsClicked
        /// </summary>
        [Test]
        public void GetContactCampaignStatsClickedInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetContactCampaignStatsClicked
            //Assert.IsInstanceOfType<GetContactCampaignStatsClicked> (instance, "variable 'instance' is a GetContactCampaignStatsClicked");
        }


        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Test]
        public void CampaignIdTest()
        {
            // TODO unit test for the property 'CampaignId'
        }
        /// <summary>
        /// Test the property 'Links'
        /// </summary>
        [Test]
        public void LinksTest()
        {
            // TODO unit test for the property 'Links'
        }

    }

}
