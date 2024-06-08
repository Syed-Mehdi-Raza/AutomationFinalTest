using System;
using OpenQA.Selenium;

namespace FinTest
{
	public class SearchUser : BaseClass
	{
		public void SearchU()
		{
			By UserName = By.ClassName("oxd-input oxd-input--active");
			By SearchBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]");
			SeleniumWrite(UserName, "MRaza3");
			SeleniumClick(SearchBtn);
		}
	}
}

