# Capstone Project: eShop Reference Application - "AdventureWorks"

## Group Information
- **Hrishav Tiwari** (A00286173)
- **Aliz Parajuli** (A00290934)

## Codebase

### Application Description
The eShop Reference Application - "AdventureWorks" is a reference .NET application implementing an e-commerce website using a services-based architecture with .NET Aspire. This application provides a robust platform for exploring e-commerce solutions.

### Key Features
- An e-commerce site selling adventure gear.
- Filtering items by brands and categories.
- Creating user accounts.
- Saving items to a cart.

### Application URL
- **Repository Link**: [https://github.com/A00286173/eshop-dotnet9.git](https://github.com/A00286173/eshop-dotnet9.git)
- The application is run locally using Docker.

### Selection Reason
This application was selected because it is an open-source project built with .NET and Docker, technologies the team is familiar with. Additionally, its focus on outdoor gear makes it exciting and engaging for the team to work on.

## Testing Strategy
The group is using Selenium to automate unit testing for the project, ensuring that both functional and non-functional aspects are thoroughly tested.

## Types of Tests

### Hrishav Tiwari's Tests
1. **UI Testing**:
   - Validates that all UI components, such as buttons, input fields, and filters, function correctly to provide a smooth user experience.
2. **Acceptance Testing**:
   - Ensures that core workflows like user registration, login, and checkout meet specified business requirements.
   
### Aliz Parajuli's Tests
1. **Compatibility Testing**:
   - Tested the project’s compatibility on Chrome and Edge browsers using Selenium WebDriver.
2. **Usability Testing**:
   - Conducted usability testing by performing the login process on the project to evaluate ease of use.


## Testing Techniques

### Hrishav Tiwari's Techniques

1. **Boundary Value Analysis**:
   - **Why It’s Appropriate**: The application includes features like price filtering, quantity selection, and category management, which require handling defined input ranges. Testing edge cases ensures robustness.
   - **Implementation**:
     - Test minimum and maximum price ranges (e.g., `$0` and `$10,000`).
     - Test edge values in quantities (e.g., `0`, `1`, and maximum stock limit).
     - Validate category selection for handling empty and large datasets.
   - **Related Testing Type**: UI Testing, as it ensures proper handling of edge cases in UI components like sliders and dropdowns.

2. **Use Case Testing**:
   - **Why It’s Appropriate**: The application’s user-driven workflows make use case testing ideal to validate real-world interactions.
   - **Implementation**:
     - Simulate user registration, login (valid and invalid), and adding items to the cart before proceeding to checkout.
   - **Related Testing Type**: Acceptance Testing, as it ensures workflows align with business requirements and provide a seamless user experience.

### Aliz Parajuli's Techniques

1. **Decision Table Testing**:
      Decision Table Testing is a technique used to model complex business logic and decision-making processes in the software. It involves creating a decision table, which lists all possible conditions and actions that the software            should perform based on those conditions. This method is particularly useful for testing systems with multiple inputs, where the output depends on a combination of conditions. The decision table helps to identify all possible             combinations of conditions, ensuring that each is tested at least once, making it easier to cover a wide range of test scenarios.
    

2. **Exploratory Testing**:
      Exploratory Testing is an approach where testers actively explore the application without predefined test cases. It involves simultaneous learning, test design, and execution, allowing testers to adapt their testing based on their 
      discoveries during the process. This method is especially useful when there is limited documentation or when the tester needs to understand the system deeply. Testers use their creativity and domain knowledge to explore different         paths and uncover issues that may not have been anticipated during scripted testing. It’s particularly effective for finding edge cases and usability issues.

## Links
- **Azure DevOps Board**: *Placeholder for the Azure DevOps board link.*
- **Slack Workspace**: *Placeholder for the Slack workspace link.*
