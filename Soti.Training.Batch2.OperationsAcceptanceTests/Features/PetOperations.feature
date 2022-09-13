Feature: Operations regarding Pets
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Soti.Training.Batch2.OperationsAcceptanceTests/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Create a new Pet
	Given the following Pet Details 0,0,doggie,dog.jpg,
  	When a new Pet is Created
	Then the new pet should be available in the store.