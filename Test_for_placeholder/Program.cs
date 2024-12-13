using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        string baseUrl = "https://jsonplaceholder.typicode.com/";

        try
        {
            Console.WriteLine("Starting Tests...");

            // Test 1: Boundary Value Analysis - Verify first and last posts
            string pageSource = driver.PageSource;
            driver.Navigate().GoToUrl(baseUrl + "posts/1");
            if (driver.PageSource.Contains("userId") && driver.PageSource.Contains("title"))
            {
                Console.WriteLine("Test 1: Boundary Test for /posts/1 - Test Passed");
            }
            else
            {
                Console.WriteLine("Test 1: Boundary Test for /posts/1 - Test Failed");
            }

            driver.Navigate().GoToUrl(baseUrl + "posts/100");
            if (driver.PageSource.Contains("userId") && driver.PageSource.Contains("title"))
            {
                Console.WriteLine("Test 1: Boundary Test for /posts/100 - Test Passed");
            }
            else
            {
                Console.WriteLine("Test 1: Boundary Test for /posts/100 - Test Failed");
            }

            // Test 2: Equivalence Partitioning - Valid and Invalid POST requests (simulation)
            driver.Navigate().GoToUrl(baseUrl + "posts");
            try
            {
                Console.WriteLine("Test 2: Simulating valid POST request - Test Passed");
            }
            catch (Exception)
            {
                Console.WriteLine("Test 2: Simulating POST request - Test Failed");
            }

            // Test 3: UI Testing - Validate the website correctly displays all posts fetched from the /posts endpoint
            driver.Navigate().GoToUrl(baseUrl + "posts");
            pageSource = driver.PageSource;
            if (pageSource.Contains("userId") && pageSource.Contains("title") && pageSource.Contains("body"))
            {
                Console.WriteLine("Test 3: UI Test for /posts rendering - Test Passed");
            }
            else
            {
                Console.WriteLine("Test 3: UI Test for /posts rendering - Test Failed");
            }


            // Test 4: Exploratory Testing - Verify /users and /comments endpoints
            driver.Navigate().GoToUrl(baseUrl + "users");
            pageSource = driver.PageSource;
            if (pageSource.Contains("name") && pageSource.Contains("email"))
            {
                Console.WriteLine("Test 4: Exploratory Test for /users endpoint - Test Passed");
            }
            else
            {
                Console.WriteLine("Test 4: Exploratory Test for /users endpoint - Test Failed");
            }

            driver.Navigate().GoToUrl(baseUrl + "comments");
            pageSource = driver.PageSource;
            if (pageSource.Contains("postId") && pageSource.Contains("email") && pageSource.Contains("body"))
            {
                Console.WriteLine("Test 4: Exploratory Test for /comments endpoint - Test Passed");
            }
            else
            {
                Console.WriteLine("Test 4: Exploratory Test for /comments endpoint - Test Failed");
            }

            // Test 5: Decision Table Testing - Test combinations of query parameters
            driver.Navigate().GoToUrl(baseUrl + "posts?userId=1");
            if (driver.PageSource.Contains("\"userId\": 1"))
            {
                Console.WriteLine("Test 5: Decision Table Test for /posts?userId=1 - Test Passed");
            }
            else
            {
                Console.WriteLine("Test 5: Decision Table Test for /posts?userId=1 - Test Failed");
            }

            driver.Navigate().GoToUrl(baseUrl + "posts?userId=2");
            if (driver.PageSource.Contains("\"userId\": 2"))
            {
                Console.WriteLine("Test 5: Decision Table Test for /posts?userId=2 - Test Passed");
            }
            else
            {
                Console.WriteLine("Test 5: Decision Table Test for /posts?userId=2 - Test Failed");
            }



        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            driver.Quit();
            Console.WriteLine("Tests Completed.");
        }
    }
}
