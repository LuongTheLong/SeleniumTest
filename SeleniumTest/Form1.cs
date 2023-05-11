using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
    public partial class Form1 : Form
    {
        IWebDriver driverGLOBAL;
        string mailAdress = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenBrw_Click(object sender, EventArgs e)
        {
            // dieu huong trinh duyet
            driverGLOBAL.Close();
        }

        private void btnOpenBrw2_Click(object sender, EventArgs e)
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            // cach 2
            IWebDriver driver = new ChromeDriver(chromeDriverService);
            driverGLOBAL = driver;
            driver.Url = "https://www.facebook.com/";
            driver.Navigate();
            var element = driver.FindElement(By.XPath("//*[@data-testid='open-registration-form-button']"));
            element.Click();
            btnGetMail.PerformClick();
            Thread.Sleep(2000); // chờ 2 giây cho mở form đăng ký ra ra
            if (!string.IsNullOrEmpty(mailAdress))
            {
                InputDataIntoFormToRegis(driver);
                Thread.Sleep(20000); // chờ 20 giây cho hoàn tất submit

                var btnContinue = driver.FindElement(By.CssSelector("div[aria-label = 'Continue']"));
                btnContinue.Click();
            }
        }

        /// <summary>
        /// Đăng ký form tự động
        /// </summary>
        /// <param name="driver"></param>
        private void InputDataIntoFormToRegis(IWebDriver driver)
        {
            var fName = driver.FindElement(By.CssSelector("input[name = 'firstname']"));
            fName.SendKeys("Luong");
            var sName = driver.FindElement(By.CssSelector("input[name = 'lastname']"));
            sName.SendKeys("Long");
            var mobileNumberOrEmailAddress = driver.FindElement(By.CssSelector("input[name = 'reg_email__']"));
            mobileNumberOrEmailAddress.SendKeys(mailAdress);
            var mobileNumberOrEmailAddressComfirm = driver.FindElement(By.CssSelector("input[name = 'reg_email_confirmation__']"));
            mobileNumberOrEmailAddressComfirm.SendKeys(mailAdress);
            var newPassword = driver.FindElement(By.CssSelector("input[name = 'reg_passwd__']"));
            newPassword.SendKeys("Obito@20082000");
            var day = driver.FindElement(By.CssSelector("select[name = 'birthday_day']"));
            day.FindElement(By.CssSelector("option[value='20']")).Click();
            var month = driver.FindElement(By.CssSelector("select[name = 'birthday_month']"));
            month.FindElement(By.CssSelector("option[value='8']")).Click();
            var year = driver.FindElement(By.CssSelector("select[name = 'birthday_year']"));
            year.FindElement(By.CssSelector("option[value='2000']")).Click();
            var gender = driver.FindElement(By.CssSelector("span[data-name = 'gender_wrapper']"));
            gender.FindElement(By.CssSelector("input[value='2']")).Click();
            var btnSubmit = driver.FindElement(By.CssSelector("button[name = 'websubmit']"));
            btnSubmit.Submit();
        }

        private void btnGetMail_Click(object sender, EventArgs e)
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            IWebDriver driverGetMail = new ChromeDriver(chromeDriverService);
            driverGetMail.Url = "https://emailfake.com/";
            driverGetMail.Navigate();
            var userName = driverGetMail.FindElement(By.CssSelector("input[id = 'userName']"));
            var stringUserName = userName.GetAttribute("value");
            var domainName = driverGetMail.FindElement(By.CssSelector("input[id = 'domainName2']"));
            var stringDomainName = domainName.GetAttribute("value");
            mailAdress = stringUserName + "@" + stringDomainName;
        }
    }
}
