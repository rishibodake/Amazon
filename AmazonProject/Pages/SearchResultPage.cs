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

        [FindsBy(How = How.XPath, Using = "//div[@data-cel-widget='search_result_1']")]
        public IWebElement Product;
    }
}
