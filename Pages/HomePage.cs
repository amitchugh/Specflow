using BDD.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
namespace BDD.Pages
{
    class HomePage : Base
    {

        public HomePage()
        {
            isPageLoad();

        }

        public bool checkHomePage()
        {
            Boolean isHomeDisplayed = false;
            try
            {
                isHomeDisplayed = driver.FindElement(By.Id("booking_engine_modues")).Displayed;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return isHomeDisplayed;
        }



        public String checkTitle()
        {
            String TitleFound = "";
            try
            {
                 TitleFound = driver.FindElement(By.XPath("//*[@id='collapsibleSection']/div/section/div/h1")).Text;
                              
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return TitleFound;
        }

        public SearchFlightPage searchFlights()
        {
            driver.FindElement(By.Id("booking_engine_flights")).Click();

            driver.FindElement(By.Id("BE_flight_origin_city")).SendKeys("New Delhi, India (DEL)");
            Console.WriteLine("New Delhi, India (DEL) is enetred");
            driver.FindElement(By.Id("BE_flight_arrival_city")).SendKeys("Mumbai, India (BOM)");
            Console.WriteLine("Mumbai, India (BOM) is entered");
            driver.FindElement(By.Id("BE_flight_origin_date")).Click();

            DateTime now = DateTime.Now;
            String fromDate = now.AddDays(2).ToString("dd/MM/yyyy");

            driver.FindElement(By.Id(fromDate)).Click();
            Console.WriteLine("fromDate : " + fromDate);
            String toDate = now.AddDays(5).ToString("dd/MM/yyyy");
            driver.FindElement(By.Id("BE_flight_arrival_date")).Click();
            driver.FindElement(By.Id(toDate)).Click();
            Console.WriteLine("toDate : " + toDate);

            driver.FindElement(By.Id("BE_flight_flsearch_btn")).Click();

            //return PageFactory.InitElements(driver, new SearchFlightPage());
            return new SearchFlightPage();
        }

    }
}
