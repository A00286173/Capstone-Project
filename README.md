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

Details about Aliz Parajuli's tests will be added later.

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

Details about Aliz Parajuli's techniques will be added later.

## Links
- **Azure DevOps Board**: *Placeholder for the Azure DevOps board link.*
- **Slack Workspace**: *Placeholder for the Slack workspace link.*
