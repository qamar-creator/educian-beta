using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educian_Automation;
using OpenQA.Selenium;
/*INCOMPLETE CLASS */
namespace Educian_Automation
{
    class Fee
    {
        public static void ShowFeeList()
        {
            //Click Dashboard
            CustomControls.click("a[data-license-type='dashboard']", propertytype.CssSelector);
            //Click Fee
            CustomControls.click("//*[@id='side-menu']/li[7]/a", propertytype.XPath);
            //Click Show Fee List
            Wait.ImplicitWait(5);
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[7]/ul/li[2]/a", propertytype.XPath);
            Wait.ImplicitWait(5);
            //Click First Row
            CustomControls.click("//*[@id='feeTbl']/tbody/tr[1]/td[5]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Next
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[2]/a", propertytype.XPath);
            //Finish
            delayfor.delay();
            CustomControls.click("//*[@id='form']/div[3]/ul/li[3]/a", propertytype.XPath);


        }

        public static void AddPaymentCClog(paymentmode payment, string confirmationNumber, string amount, string bankCharges = "0", string creditaccounts = "FDI-987768", string recievedfrom = "CLARENCE ONEIL", string country = "United States", string state = "IL", string city = "Illinois", string pin = "62033", string addressline1 = "2633  Spring Street, Gillespie")
        {
            //Click Dashboard
            CustomControls.click("a[data-license-type='dashboard']", propertytype.CssSelector);
            //Click Fee
            Wait.ImplicitWait(10);
            CustomControls.click("//*[@id='side-menu']/li[7]/a", propertytype.XPath);
            //Click Cash Control Log
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[7]/ul/li[4]/a", propertytype.XPath);
            //Click add button
            CustomControls.click("//*[@id='page-wrapper']/div[2]/div/div[2]/a", propertytype.XPath);
            //Recieved From
            CustomControls.Entertext("#receivedFrom", recievedfrom, propertytype.CssSelector);
            delayfor.delay();
            PropertiesCollection.ngdriver.FindElement(By.CssSelector("#receivedFrom")).SendKeys(Keys.Down);
            delayfor.delay();
            PropertiesCollection.ngdriver.FindElement(By.CssSelector("#receivedFrom")).SendKeys(Keys.Enter);
            PropertiesCollection.ngdriver.FindElement(By.CssSelector("#receivedFrom")).SendKeys(Keys.Enter);
            delayfor.delay();
            //Select Student 
            CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div[8]/a", propertytype.XPath);
            delayfor.delay();
            CustomControls.Entertext("#registrationNumber", "UID-1003-2021", propertytype.CssSelector);
            CustomControls.click("#searchStudents", propertytype.CssSelector);
            CustomControls.click("#completebatch", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("//*[@id='EnrollBtn']", propertytype.XPath);
            //#addressline1
            delayfor.delay();
            CustomControls.Entertext("#addressline1", addressline1, propertytype.CssSelector);
            //country
            CustomControls.click("#country", propertytype.CssSelector);
            CustomControls.Selectdropdown("#country", country, propertytype.CssSelector);
            //#state
            CustomControls.Entertext("#state", state, propertytype.CssSelector);
            //#city
            CustomControls.Entertext("#city", city, propertytype.CssSelector);
            //#pin
            CustomControls.Entertext("#pin", pin, propertytype.CssSelector);
            //#confirmationNumber
            CustomControls.Entertext("#confirmationNumber", confirmationNumber, propertytype.CssSelector);
            //#amount
            CustomControls.Entertext("#amount", amount, propertytype.CssSelector);
            //#bankCharges
            CustomControls.Entertext("#bankCharges", bankCharges, propertytype.CssSelector);
            //payment mode
            CustomControls.click(String.Format("//*[@id='addForm']/div/div/div/div[9]/div/div[{0}]/input", (int)payment), propertytype.XPath);
            //CreditAccounts
            CustomControls.click("#bankAccounts", propertytype.CssSelector);
            CustomControls.Selectdropdown("#bankAccounts", creditaccounts, propertytype.CssSelector);
            //OK
            CustomControls.click("button[class='btn btn-warning btn-outline']", propertytype.CssSelector);
            delayfor.delay();
            //Confirm OK
            CustomControls.click("button[class='confirm']", propertytype.CssSelector);
        }

        public static void FeeCollection(paymentmode payment, string confirmationNumber, string creditaccounts = "FDI-987768")
        {
            /*
             * SHERRI RHODES
UID: UID-1025-2021
Class: 2nd
Roll No.: 2
Session: 2021
Date Of Birth: 12/23/2004
Admission Date: 02/18/2021
             */
            //Click Dashboard
            Wait.ImplicitWait(10);
            CustomControls.click("a[data-license-type='dashboard']", propertytype.CssSelector);
            //Click Fee
            CustomControls.click("//*[@id='side-menu']/li[7]/a", propertytype.XPath);
            //Click Fee Collection
            CustomControls.click("/html/body/div[2]/nav/div/ul/li[7]/ul/li[5]/a", propertytype.XPath);
            //click Student Name
            CustomControls.Entertext("#studentName", "SHERRI RHODES", propertytype.CssSelector);
            delayfor.delay();
            PropertiesCollection.ngdriver.FindElement(By.CssSelector("#studentName")).SendKeys(Keys.Down);
            delayfor.delay();
            PropertiesCollection.ngdriver.FindElement(By.CssSelector("#studentName")).SendKeys(Keys.Enter);
            /*string invoiceno = PropertiesCollection.ngdriver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[3]")).Text;
            //*[@id="invoiceNo_-3793144930"]
            CustomControls.click(String.Format("//*[@id='invoiceNo_-{0}']", invoiceno), propertytype.XPath);*/
            CustomControls.click("/html/body/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div/div/div/div/div[2]/div/div/div/div[2]/div[1]/div/table/tbody/tr[1]/td[1]/div/input", propertytype.XPath);
            CustomControls.click("//*[@id='applyBtn']", propertytype.XPath);

            //recieved from
            CustomControls.click("//*[@id='receivedFrom']", propertytype.XPath);
            CustomControls.Selectdropdownindex("//*[@id='receivedFrom']", 1, propertytype.XPath);
            //payment mode
            CustomControls.click(String.Format("//*[@id='addForm']/div/div/div/div[11]/div/div[{0}]/input", (int)payment), propertytype.XPath);
            //#confirmationNumber
            CustomControls.Entertext("#confirmationNumber", confirmationNumber, propertytype.CssSelector);
            //CreditAccounts
            CustomControls.click("#bankAccounts", propertytype.CssSelector);
            CustomControls.Selectdropdown("#bankAccounts", creditaccounts, propertytype.CssSelector);
            //save payment
            CustomControls.click("#savePayment", propertytype.CssSelector);
            delayfor.delay();
            CustomControls.click("button[class='confirm']", propertytype.CssSelector);

        }
    }


}
