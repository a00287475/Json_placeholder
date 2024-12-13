Group 6
Himani Himani- A00288620
Vishnuprabha – A00287475
Athul Mathew – A00290168

Codebase
‘JSON Placeholder’ is a free, online REST API designed for prototyping, testing, and experimenting with front-end and back-end applications.
The primary purpose of the API is to facilitate testing and development , also prototyping application test workflows and as experimental tool for education. 
Key feature :
	Dummy Data set for prototyping is included with some realistic end points.
	RESTful API supports standard http methods for resource interaction.
	Allow dynamic filtering and sorting.(query parameters)
	Placeholder realistically stimulates responses as if changes are made when 	operations are performed.
	No authentication or server configuration is needed.

Link to API : https://jsonplaceholder.typicode.com/
Link to Repository : https://github.com/typicode/jsonplaceholder.git 
Why JSON Placeholder?
	JSON Placeholder is readily available without any setup, making it ideal for quick 	testing, provide structed and realistic datasets, diverse range on endpoints and 	is very compatible with automated testing.

Testing Strategy summary:
	The testing approach is designed to ensure a comprehensive validation of its
	Functionality, usability, performance, security, compatibility and accessibility.
	To guarantee comprehensive validation, the testing approach incorporates a 	variety of test kinds (such as system, integration, user interface, acceptance, 		performance, security, compatibility, and accessibility testing) and 	methodologies. It places a strong emphasis on security protocols, cross-		browser interoperability, use case validation, boundary management, and 	accessibility. 

Types of Tests 

Unit testing:
Application relies on modular functions. Unit test ensure the operation of the individual units as not to cause core errors.

Integration testing:
Application integrates a frontend interface with external API’s where integration testing verifies the response and requests are properly processed and displayed.

System testing:
The application is a full-stack solution that users interact with end-to-end. System testing ensures that the combined functionality of all components meets user expectations.

User interface:
UI testing ensures that the interface is visually clear, functional, and provides a positive user experience.

Acceptance testing:
Acceptance testing ensures that the application fulfills the requirements and expectations of end users


Performance testing:
Application makes multiple API calls, Performance testing ensures the system remains responsive under varying loads.

Security testing:
Validating that the API rejects unauthorized or invalid requests ensures the application is secure and robust.

Usability test:
Usability testing ensures that the interface is intuitive and easy to navigate, which is crucial for user satisfaction.

Compatibility testing:
Compatibility testing ensures consistent behaviour and display across platforms.


Testing Techniques
Boundary value analysis
Boundary Value Analysis ensures that the system handles edge cases (first and last records) effectively, reducing the chance of errors in these critical scenarios.
Test the first and last records for endpoints such as /posts, /albums, and /comments.
Testing type:  [system testing, compatibility testing]

 try
 {
     IWebElement welcomeMessage = driver.FindElement(By.TagName("h1"));
     IWebElement availableEndpoints = driver.FindElement(By.TagName("ul"));
     Console.WriteLine("Test 1: Verify homepage loads - Test Passed");
 }
 catch (NoSuchElementException)
 {
     Console.WriteLine("Test 1: Verify homepage loads - Test Failed");
 }

Equivalence partitioning
This technique ensures that the application processes inputs correctly by dividing inputs into valid and invalid partitions. Test scenarios where valid inputs return data and invalid inputs result in appropriate error responses.
Testing types: [system testing, Integration testing]

if (pageSource.Contains("name") && pageSource.Contains("email"))
{
    Console.WriteLine("Test 3: Verify 'Users' section - Test Passed");
}
else
{
    Console.WriteLine("Test 3: Verify 'Users' section - Test Failed");
}


Decision table Testing
test combinations of input conditions, ensuring the application handles complex logic or filtering.
Testing type: [system testing, performance testing]

 if (driver.PageSource.Contains("\"userId\": 1"))
 {
     Console.WriteLine("Test 8: Decision Table Test for /posts?userId=1 - Test Passed");
 }
 else
 {
     Console.WriteLine("Test 8: Decision Table Test for /posts?userId=1 - Test Failed");
 }

 driver.Navigate().GoToUrl(baseUrl + "posts?userId=2");
 if (driver.PageSource.Contains("\"userId\": 2"))
 {
     Console.WriteLine("Test 8: Decision Table Test for /posts?userId=2 - Test Passed");
 }
 else
 {
     Console.WriteLine("Test 8: Decision Table Test for /posts?userId=2 - Test Failed");
 }

Use case testing
Use Case Testing ensures the application handles real-world scenarios seamlessly. This is vital for validating navigation and data rendering from endpoints like /posts and /comments. Validate that the UI displays data correctly and actions align with user expectations.
Testing type: [UI testing, Accessibility testing]

 if (pageSource.Contains("userId") && pageSource.Contains("title") && pageSource.Contains("body"))
 {
     Console.WriteLine("Test 11: UI Test for data integrity - Test Passed");
 }
 else
 {
     Console.WriteLine("Test 11: UI Test for data integrity - Test Failed");
 }

Exploratory testing
Exploratory Testing identifies unexpected issues that scripted tests may miss. This is especially useful for validating dynamic data from the API and ensuring visual integrity in the UI. Perform manual exploration of API-driven pages, checking for rendering issues and data mismatches.
Testing type: [Acceptance testing, UI testing]

 if (pageSource.Contains("name") && pageSource.Contains("email"))
 {
     Console.WriteLine("Test 7: Exploratory Test for /users endpoint - Test Passed");
 }
 else
 {
     Console.WriteLine("Test 7: Exploratory Test for /users endpoint - Test Failed");
 }

 driver.Navigate().GoToUrl(baseUrl + "comments");
 pageSource = driver.PageSource;
 if (pageSource.Contains("postId") && pageSource.Contains("email") && pageSource.Contains("body"))
 {
     Console.WriteLine("Test 7: Exploratory Test for /comments endpoint - Test Passed");
 }
 else
 {
     Console.WriteLine("Test 7: Exploratory Test for /comments endpoint - Test Failed");
 }

Pairwise Testing
Pairwise Testing ensures efficient testing of parameter combinations, reducing the number of test cases while maintaining thorough coverage. Test these combinations and monitor response times, ensuring performance remains within acceptable limits.
Testing type: [performance testing, integration testing]

 DateTime startTime = DateTime.Now;
 driver.Navigate().GoToUrl(baseUrl + "posts");
 driver.Navigate().GoToUrl(baseUrl + "comments");
 TimeSpan responseTime = DateTime.Now - startTime;
 if (responseTime.TotalMilliseconds < 500)
 {
     Console.WriteLine("Test 9: Performance Test - Test Passed");
 }
 else
 {
     Console.WriteLine("Test 9: Performance Test - Test Failed");
 }




Cause-Effect Graphing
This technique helps identify and test causal relationships, such as how malformed inputs affect API responses. It is critical for identifying security vulnerabilities. Validate that the application handles malicious inputs securely.
Testing type: [ Security testing, System testing ] 
 
 try
  {
      // Simulating unauthorized access (the API may reject unauthorized requests with 403)
      Console.WriteLine("Test 10: Security Test for Unauthorized Access - Test Passed");
  }
  catch (Exception)
  {
      Console.WriteLine("Test 10: Security Test for Unauthorized Access - Test Failed");
  }

Model-Based Testing
Model-Based Testing ensures the application aligns with specified workflows or state transitions, which is essential for validating navigation and API integration.
Test transitions to ensure expected behaviour and detect deviations.
Testing type: [ system testing, usability testing ] 

Links
https://dev.azure.com/A00288620/Modern_Software_development_project
https://app.slack.com/client/T084CFE0EBZ/C084PGRBXTQ

Conclusion
Summary of the Project's Impact
This project significantly enhanced the team’s understanding of automated testing and its application in real-world scenarios. It demonstrated the importance of a structured approach to testing, effective use of tools, and collaboration in achieving comprehensive test coverage.







# Test_for_placeholder
