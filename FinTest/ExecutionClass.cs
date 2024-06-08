using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FinTest;

public class Tests : BaseClass
{
    /*public static IWebDriver driver;
    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
    }
    [TearDown]
    public void TearDown()
    {
        driver.Close();
    }
    [Test]
    public void Test1()
    {
        Thread.Sleep(2000);
        driver.FindElement(By.XPath("//*[@id=\"app-main\"]/div/div[1]/section/div/div[2]/div[2]/a")).Click();
        Thread.Sleep(5000);
    }*/

    [Test]
    public void TestMethod()
    {
        SeleniumOpn();

        InvalidLogin inlog = new();
        inlog.SignFa();

        Login login = new();
        login.Signin();

        AddUser addUser = new();
        addUser.AddNewUser();

        Thread.Sleep(5000);

        SearchUser searchUser = new();
        searchUser.SearchU();

    }



}


