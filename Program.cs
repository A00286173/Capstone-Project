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
            // Set the path of the EdgeDriver executable if it's not in the system PATH
            var edgeOptions = new EdgeOptions();
            //edgeOptions.AddArgument("headless"); // Runs browser in headless mode (optional)
            //edgeOptions.AddArgument("disable-gpu"); // Disable GPU (optional)
            
            // Initialize the Edge WebDriver
            IWebDriver driver = new EdgeDriver(edgeOptions);

            try
            {
                // Navigate to the login page
                Console.WriteLine("Navigating to Login Page...");
                driver.Navigate().GoToUrl("https://localhost:5243/Account/Login");
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);

                // Find and fill in the username field
                Console.WriteLine("Entering username...");
                IWebElement uname = driver.FindElement(By.Name("Username"));
                uname.SendKeys("alice");

                // Find and fill in the password field
                Console.WriteLine("Entering password...");
                IWebElement pass = driver.FindElement(By.Name("Password"));
                pass.SendKeys("Pass123$");

                // Click the login button
                Console.WriteLine("Clicking login button...");
                IWebElement loginButton = driver.FindElement(By.Name("button"));
                loginButton.Click();

                // Wait for a few seconds to let the page load
                Thread.Sleep(3000);

                // Navigate to the homepage
                Console.WriteLine("Navigating to Home Page...");
                driver.Navigate().GoToUrl("https://localhost:7298/");
                driver.Manage().Window.Maximize();
                Thread.Sleep(3000);

                // Click the login button on the homepage
                Console.WriteLine("Clicking login on the homepage...");
                IWebElement login = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/nav/a[2]/img"));
                login.Click();
                
                // Wait for a few seconds
                Thread.Sleep(3000);

                // Click the logout button
                Console.WriteLine("Clicking logout button...");
                IWebElement logout = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/nav/div/div/form/button"));
                logout.Click();

                // Print success message
                Console.WriteLine("Test completed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Close the browser
                Console.WriteLine("Closing browser...");
                driver.Quit();
            }
        }
    }
}
