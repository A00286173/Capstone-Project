using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SeleniumYouTubeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the type of testing to perform:");
            Console.WriteLine("1. UI Testing");
            Console.WriteLine("2. Use Case Testing");
            Console.Write("Enter your choice (1 or 2): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                PerformUITesting();
            }
            else if (choice == "2")
            {
                PerformUseCaseTesting();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }

        static IWebDriver StartWebDriver()
        {
            var edgeOptions = new EdgeOptions();
            IWebDriver driver = new EdgeDriver(edgeOptions);
            driver.Manage().Window.Maximize();
            return driver;
        }

        static void PerformUITesting()
        {
            IWebDriver driver = StartWebDriver();
            try
            {
                Console.WriteLine("Navigating to Login Page...");
                driver.Navigate().GoToUrl("https://localhost:5243/Account/Login");
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);

                Console.WriteLine("Entering username...");
                IWebElement uname = driver.FindElement(By.Name("Username"));
                uname.SendKeys("alice");

                Console.WriteLine("Entering password...");
                IWebElement pass = driver.FindElement(By.Name("Password"));
                pass.SendKeys("Pass123$");

                Console.WriteLine("Clicking login button...");
                IWebElement loginButton = driver.FindElement(By.Name("button"));
                loginButton.Click();

                Thread.Sleep(3000);

                Console.WriteLine("Navigating to Home Page...");
                driver.Navigate().GoToUrl("https://localhost:7298/");
                driver.Manage().Window.Maximize();
                Thread.Sleep(3000);

                Console.WriteLine("Clicking login on the homepage...");
                IWebElement login = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/nav/a[2]/img"));
                login.Click();

                Thread.Sleep(3000);

                Console.WriteLine("Clicking logout button...");
                IWebElement logout = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/nav/div/div/form/button"));
                logout.Click();

                Console.WriteLine("UI Test completed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during UI testing: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Closing browser...");
                driver.Quit();
            }
        }

        static void PerformUseCaseTesting()
        {   

          
                Console.WriteLine("Starting Use Case Testing...");

                Console.Write("Enter username for login: ");
                string inputUsername = Console.ReadLine();

                Console.Write("Enter password for login: ");
                string inputPassword = Console.ReadLine();

                IWebDriver driver = StartWebDriver();

            try
            {
                Console.WriteLine("Use Case testing: Login");
               
                driver.Navigate().GoToUrl("https://localhost:5243/Account/Login");
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);

                IWebElement uname = driver.FindElement(By.Name("Username"));
                uname.SendKeys(inputUsername);

                IWebElement pass = driver.FindElement(By.Name("Password"));
                pass.SendKeys(inputPassword);

                IWebElement loginButton = driver.FindElement(By.Name("button"));
                loginButton.Click();

                Thread.Sleep(3000);

                bool isLoginSuccessful = driver.Url.Contains("/Home");
                Console.WriteLine(isLoginSuccessful ? "Test Case Passed" : "Test Case Failed");

                Console.WriteLine("Use Case Testing completed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during Use Case testing: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Closing browser...");
                driver.Quit();
            }
        }
    }
}
