# Tax Calculator
This application takes a user's information (SSN, name, salary, etc.) and will compute how much they will owe in taxes and how much they will have left over using the 2015 tax bracket data from the IRS.

*These are rough calculations using only salary as the determinant factor*

## Examples
We run the program and see the first window pop up. Let's choose 'Single' as the filing status in the drop down menu.
Hit the Enter button, and now we will see the second, navy colored form appear.

Let's try creating a user in our database; we'll call him John Doe. We need to give him an SSN and a yearly salary.
For simplicity sake, his social will be 111-11-1111 and he will make $56,000 a year.

### Calculate
Select the Calculate button, and watch the magic take place as the code calculates how much money John will owe at the end of the year.
The tax owed will be $14,294. Following suit, the Taxed Salary will populate an answer by subtracting the amount of tax owed from John's total salary. The value will be $41,706‬.

### Submit
If we'd like to enter this data into our database, we need to select the Submit button, and we will get a message that says, "The record was entered into the database". If it fails, we will see, "The data was not entered into the database".

### Update
If we wish to update the user's filing status, we first must go through the first form, select the desired status, then enter in any new data (or re-enter the old data) and hit update.

*Note:*

*If a new SSN or the old SSN is not included, the record will not be updated.*

*Also, while still in the second window, any yearly salary entered will still be taxed according the previously selected status from the drop down menu.*

### Clear
This button will clear any data inside the text boxes.

### Delete
If we want to delete an entire user from our database, we first must enter their SSN, then hit the Delete button.

The program will issue a warning, asking us if we wish to continue with the action, giving us the option to select Yes or No.

## Prerequisites

### What you'll need to run the code:

* Internet connection

* Visual Studios 2012 v 11.0

* MS SQL Server 2012 v 11.0

### Download the latest versions:

https://visualstudio.microsoft.com/downloads/

https://www.microsoft.com/en-us/sql-server/sql-server-downloads# 
