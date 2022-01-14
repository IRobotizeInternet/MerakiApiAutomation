using MerakiApiAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MerakiApiAutomation.Tests
{
    [TestClass]
    public class MerakiAppTest
    {
        [TestMethod, DoNotParallelize]
        public void VerifyTotalNetworksCount()
        {
            const int totalExpectedNetworkCount = 4;
            var pageLogin = new PageLogin();
            pageLogin.TextboxAPIKey.SetText("<ADD API KEY HERE>");
            var networksPage = pageLogin.ButtonGo.Click();
            Assert.AreEqual(totalExpectedNetworkCount, networksPage.Networks().Count, $"Unexpected number of networks: {networksPage.Networks().Count}");
        }

        [TestMethod, DoNotParallelize]
        public void VerifyNetworkByName()
        {
            const string networkName = "Wireless New Stadium";
            var pageLogin = new PageLogin();
            pageLogin.TextboxAPIKey.SetText("<ADD API KEY HERE>");
            var networksPage = pageLogin.ButtonGo.Click();

            Assert.IsTrue(networksPage.CheckNetworkExist(networkName), $"Network:{networkName} not found");
        }

        [TestMethod, DoNotParallelize]
        public void VerifyNetworkDetailsOfAGivenNetworkName()
        {
            const string networkName = "Wireless New Stadium";
            var networkDetail = new[] {
                "Model",
                "Serial",
                "Usage",
                "Number of clients"
            };
            var pageLogin = new PageLogin();
            pageLogin.TextboxAPIKey.SetText("<ADD API KEY HERE>");
            var networksPage = pageLogin.ButtonGo.Click();
            var network = networksPage.Networks().Where(x=>x.LabelDeviceName.Element.Text == networkName).First();
            Assert.IsNotNull(network, $"Network of name: {networkName} not found");
            var networkDetailsPage = new PageNetworkDetails();
            Assert.AreEqual(networkDetail[0], networkDetailsPage.LabelModel.Text);
            Assert.AreEqual(networkDetail[1], networkDetailsPage.LabelSerial.Text);
            Assert.AreEqual(networkDetail[2], networkDetailsPage.LabelUsage.Text);
            Assert.AreEqual(networkDetail[3], networkDetailsPage.LabelNumClientsValue.Text);
        }
    }
}
