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
    class SearchFlightPage : Base
    {

        public SearchFlightPage()
        {
            //isPageLoad();
        }

        public void selectLowestFair()
        {


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='resultList_0']/div[1]/div[1]//ul[1]/li[4]//label[1]//input[@type='radio']")));
            driver.FindElement(OpenQA.Selenium.By.XPath("//div[@id='resultList_0']/div[1]/div[1]//ul[1]/li[4]//label[1]//input[@type='radio']")).Click();

            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='resultList_1']/div[1]/div[1]//ul[1]/li[4]//label[1]//input[@type='radio']")));

            driver.FindElement(By.XPath("//div[@id='resultList_1']/div[1]/div[1]//ul[1]/li[4]//label[1]//input[@type='radio']")).Click();
            String totalFare = driver.FindElement(By.Id("fare-selSum")).Text;

            Console.WriteLine("Total fare : " + totalFare);

            String rawFare = totalFare.Replace('.', ' ');
            rawFare = rawFare.Replace(',', ' ');
            rawFare = rawFare.Remove(0, 2).TrimStart();
            string[] rawFare1 = rawFare.Split(new Char[] { ' ' });
            rawFare = rawFare1[0] + rawFare1[1];
            Console.WriteLine("rawFare : " + rawFare);

            if (Int32.Parse(rawFare) < 10000)
            {
                Console.WriteLine("Fair is economical");

            }
            else
            {
                Console.WriteLine("Fair is costly");
            }


        }

        public void getNumberOfFlight()
        {
            String Raw_numberOfFlights = driver.FindElement(By.XPath("//*[@id='resultBox']/div[1]/div[3]/p[1]")).Text;
            string[] Rawnumber = Raw_numberOfFlights.Split(new Char[] { ' ' });
            int numberOfFlights = Int32.Parse(Rawnumber[1]);

            IReadOnlyCollection<IWebElement> records = null;

            do
            {
                driver.FindElement(By.XPath("//div[@class='full srp-wrapper']")).SendKeys(Keys.PageDown);
                records = driver.FindElements(By.XPath("//div[@class='js-flightRow js-flightItem']"));

                Console.WriteLine("Number of Records: " + records.Count);

            } while (records.Count != numberOfFlights);

            if (records.Count == numberOfFlights)
            {
                Console.WriteLine("Total Number of Records on Page are match with the total. Which are: " + records.Count);
            }



        }

        public void selectThirdLowest()
        {



        }

    }
}
