using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.WebRequestMethods;

namespace webdiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1d
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
       
            //1a,1b
            string url = textBox1.Text;
            if (string.IsNullOrWhiteSpace(url))
                url = "https://www.google.com/";


            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl(url);

            //1f
            String link_hientai = driver.Url;
            Console.WriteLine(link_hientai);
            //1g
            String Titlte_hientai = driver.Title;
            Console.WriteLine(Titlte_hientai);
            textBox1.Text= Titlte_hientai;
            //1h
            String PageSource_hientai = driver.PageSource;
            Console.WriteLine(PageSource_hientai);

            //1c
            /* driver.Close();
             //1e
             driver.Quit();*/

            //1i
            driver.Navigate().Back();
            driver.Navigate().Forward();
            Thread.Sleep(2000);
            driver.Navigate().Refresh();

            IWebElement tk = driver.FindElement(By.Id("email"));
            tk.SendKeys("nnn88976@gmail.com");

            IWebElement mk = driver.FindElement(By.CssSelector("input[type='password']"));
            mk.SendKeys("konodioda343");

            IWebElement button = driver.FindElement(By.Name("login"));
            button.Click();

            //upload anh web khac

            /*IWebElement up = driver.FindElement(By.Name("filename"));
            up.SendKeys(@"C:\Users\lemin\Videos\Captures\fc.png");

            IWebElement check = driver.FindElement(By.Name("filetype"));
            check.Click();

            IWebElement submit = driver.FindElement(By.Name("upload"));
            submit.Click();*/

            /*driver.SwitchTo().Alert().Accept();*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

   

            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl("https://www.facebook.com");

            IWebElement tk = driver.FindElement(By.Id("email"));
            tk.SendKeys(textBox2.Text);

            IWebElement mk = driver.FindElement(By.CssSelector("input[type='password']"));
            mk.SendKeys(textBox3.Text);

            IWebElement button = driver.FindElement(By.Name("login"));
            button.Click();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl("https://www.facebook.com");
            driver.FindElement(By.LinkText("Sign up for Facebook")).Click();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl("https://www.facebook.com");
            driver.FindElement(By.LinkText("Forgotten password?")).Click();

            IWebElement email = driver.FindElement(By.Id("identify_email"));
            email.SendKeys("leduc9a7@gmail.com");

            IWebElement button = driver.FindElement(By.Name("did_submit"));
            button.Click();
            Thread.Sleep(1000);
        }
    }
}
