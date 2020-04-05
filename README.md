# CS291 Project

![Login](https://github.com/efirdc/CS291_Project/blob/master/ImagesManual/login.PNG?raw=true)

For login you enter a user name and password then click login, or click new user button to create a new one.

![UnselectedNewUser](https://github.com/efirdc/CS291_Project/blob/mohammad/ImagesManual/newuserunselected.png?raw=true)

The sign up form gives you the option to sign up as a customer, employee, or adminstrator.

![CustomerNewUser](https://github.com/efirdc/CS291_Project/blob/mohammad/ImagesManual/newusercustomer.png?raw=true)

Selecting customer will show the four fields needed to create a customer account.

![EmployeeNewUser](https://github.com/efirdc/CS291_Project/blob/mohammad/ImagesManual/newuseremployee.png?raw=true)

Selecting emplyee will show the same four fields as well as an additional field used to determine which branch the employee belongs to.

![Charts](https://github.com/efirdc/CS291_Project/blob/master/ImagesManual/Chart.PNG?raw=true)

For the charts/reports page you just click any button above the divide in any combination (please don't do more then 6, it will be a long wait) and it will display all the combinations in a graph.
![Tables](https://github.com/efirdc/CS291_Project/blob/master/ImagesManual/tables.PNG?raw=true)

For the tables tab you can add an entry or edit current entries, or clear all entries. Clear all entries is bottom right. Save the table is bottom left. Selection of current table is bottom middle. And then it's straight forward how to enter/edit entries. 

## Booking Menu
![Booking](https://github.com/efirdc/CS291_Project/blob/cory/booking.png?raw=true)

The booking menu allows you to create a booking for the currently active customer. When a customer logs into the system they will immediately enter the booking menu. Employees can also access this menu for any customer from the employee menu.

First you must select a start date for the booking, a pick up branch, and a drop off branch. The "Select Car" drop down will be populated with model names of cars that are available for pick up at that branch. The end date and cost of the booking are automatically determined based on the billing cycle, number of cycles, and rental price of the car. If a customer makes 3 bookings in the same year, a message will be displayed that they have received a gold star membership. An error message will be displayed if any field is not filled in or if the booking date is in the past.

## Employee Main Menu
![Employee](https://github.com/efirdc/CS291_Project/blob/mohammad/ImagesManual/employeeform.png?raw=true)

The main menu for the employee will have 3 main features:
1. The option to select a customer from the list of existing customers available and book a rental on their behalf using the booking system talked about above.
2. The option selecting currently active rentals and a drop off branch in order to drop off a car for a customer. If the customer is dropping off a car at a branch different from what is stored in the system, then they must pay a fee. This fee can be waived if the customer is a gold member.
3. Add additional:
    1. Cars
    2. Car types
    3. Pricing models
In all these cases, when an operation is complete, a message box will pop up confirming the user's action.

![Cars](https://github.com/efirdc/CS291_Project/blob/mohammad/ImagesManual/addcar.png?raw=true)

In order to add a car to the system, the employee must input the car ID (VIN number?), select a branch from the list of existing branches, and a car type from a list of existing car types.

![CarTypes](https://github.com/efirdc/CS291_Project/blob/mohammad/ImagesManual/addcartype.png?raw=true)

Car types require the textboxes to be filled in and a pricing model must be selected from the list of existing pricing models in the drop down menu. The number boxes default to 0 and the checkboxes default to false.

![PricingModels](https://github.com/efirdc/CS291_Project/blob/mohammad/ImagesManual/addpricingmodel.png?raw=true)

The employee must input a model name and the model pricing in order to add a new pricing model.
