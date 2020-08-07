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

        [FindsBy(How = How.XPath, Using = "//a[@href='https://www.amazon.in/gp/cart/view.html?ref_=nav_cart']")]
        public IWebElement CartPage;

        [FindsBy(How = How.XPath, Using = "//a[@id='hlb-ptc-btn-native']")]
        public IWebElement ProceedToBuy;
    }
}
