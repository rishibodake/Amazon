using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonProject.Pages
{
    public class SearchResultPage
    {
        public SearchResultPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        public IWebElement AddToCart;
    }
}
