using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class PictureUpload
{
    static void Main()
    {
        //Chrome maximized option on initalization
        ChromeOptions chromeOptions = new ChromeOptions();
        chromeOptions.AddArguments("--start-maximized");

        //Open Chrome and pass the options to maximize the window
        IWebDriver driver = new ChromeDriver(chromeOptions);

        //Navigate to OrangeHRM website
        driver.Navigate().GoToUrl("http://opensource.demo.orangehrmlive.com/");

        //HTML element name for username
        IWebElement username = driver.FindElement(By.Name("txtUsername"));
        username.SendKeys("robert.craig");

        //Pause for 3 seconds before moving to next element
        Thread.Sleep(3000);

        //HTML element name for password
        IWebElement password = driver.FindElement(By.Name("txtPassword"));
        password.SendKeys("robert.craig");

        //Pause for 3 seconds before moving to next element
        Thread.Sleep(3000);

        //Click on submit button
        driver.FindElement(By.Id("btnLogin")).Click();

        //Click on My Info Tab
        driver.FindElement(By.Id("menu_pim_viewMyDetails")).Click();

        //Pause for 2 seconds before moving to next element
        Thread.Sleep(2000);

        //Click on Photo Frame
        driver.FindElement(By.Id("empPic")).Click();

        //Add a Picture from Desktop
        driver.FindElement(By.Name("photofile")).SendKeys(@"C:\Users\faiza\Desktop\RobertCraig.jpg");

        //Pause for 2 seconds before moving to next element
        Thread.Sleep(2000);

        //Click on Upload
        driver.FindElement(By.Id("btnSave")).Click();

        //Pause for 3 seconds before moving to next element
        Thread.Sleep(3000);

        //Click on delete
        driver.FindElement(By.Id("btnDelete")).Click();

        //Pause for 2 seconds before moving to next element
        Thread.Sleep(2000);

        //Click Yes
        driver.FindElement(By.Id("btnYes")).Click();

        //Pause for 3 seconds before moving to next element
        Thread.Sleep(3000);

        //Quit program
        driver.Quit();
    }
}

