﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    private static void Main(string[] args)
    {
       // Open Chrome browser
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        // Launch Skillswap portal
        driver.Navigate().GoToUrl("http://localhost:5000/");

        // Click sign in button
        IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        signinButton.Click();

        // Identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Name("email"));
        usernameTextbox.SendKeys("sanaljacob19@gmail.com");
        // Identify password textbox and enter valid password
        IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
        passwordTextbox.SendKeys("anjusanal");
        // Click login button
        IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        loginButton.Click();
        Thread.Sleep(6000);
        // Check if the user lob in successfully
        IWebElement sanalJacob = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
        if(sanalJacob.Text == "Sanal Jacob")
        {
            Console.WriteLine("User has log in successfully");

        }
        else
        {
            Console.WriteLine("User has not log in");
        }

        // Validate profile picture 
        //IWebElement profilePicture = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[1]"));
        //profilePicture.Click();


        // EDIT NAME
        // Select dropdown list
        IWebElement dropdownButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
        dropdownButton.Click();
        // change last name
        IWebElement lastnameTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
        lastnameTextbox.Clear();
        lastnameTextbox.SendKeys("Anju");
        IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
        saveButton.Click();

        //Checking editing function
        if(lastnameTextbox.Text == "Anju")
        {
            Console.WriteLine("Editing functionality working successfully");
        }
        else
        {
            Console.WriteLine("Editing functionality failed");
        }

        //SELECT COUNTRY




    }
}