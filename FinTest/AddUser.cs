using System;
using OpenQA.Selenium;

namespace FinTest
{
	public class AddUser : BaseClass
	{
		public void AddNewUser()
		{
			By AdminTab = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a");
			By AddBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[1]/button");
			By EmpName = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input");
			By UsrName = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input");
			By PassBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[1]/div/div[2]/input");
			By ConfPassBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/div/div[2]/input");
			By SaveBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[3]/button[2]");

			Thread.Sleep(4000);
			SeleniumClick(AdminTab);
			Thread.Sleep(2000);

			SeleniumClick(AddBtn);
			Thread.Sleep(4000);

			//Select User Role
			myDriver.FindElement(By.ClassName("oxd-select-text-input")).SendKeys("Admin");
			myDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div[2]/div[2]")).Click();

			//Select Employee Name
			myDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input")).SendKeys("T");
			Thread.Sleep(2000);
			myDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div[2]/div[1]")).Click();

			//Select Status
			myDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[1]")).SendKeys("Enabled");
			myDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div[2]/div[2]")).Click();


			SeleniumWrite(UsrName, "MRaza3");
			SeleniumWrite(PassBtn, "1234Abc");
			SeleniumWrite(ConfPassBtn, "1234Abc");

			SeleniumClick(SaveBtn);

        }
	}
}

