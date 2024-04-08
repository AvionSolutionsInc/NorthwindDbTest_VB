# NorthwindDbTest_VB
A very simple data-driven business web application similar in nature to what
Avion Solutions, Inc. maintains for its US Army customers.  It is an ASP.NET web application written in Visual Basic.  Our goal is to gather information about how you interpret requirements
and go about implementing them.  We will look at the code you write and the end product to help drive conversation
during a possible interview.  This test consists of implementing two requirements that are detailed below.

## Prerequisites
This test requires you be able to work with a simple Visual Studio solution.  A community version of Visual Studio can be found here: [https://visualstudio.microsoft.com/vs/community/](https://visualstudio.microsoft.com/vs/community/)

## Take the test
In order to take this test, please fork the repository and perform your work in your own local repository.\
When finished, please see the [How To Submit](#how-to-submit) section for guidance.

## About this test
### JavaScript Libraries
This project includes the following JavaScript libraries:
* jQuery 3.4.1
* Bootstrap 5.2
* Bootstrap Icons 1.10

### Requirement #1
The Products page currently loads all products in the database.  The customer would like to expand the Products page to include a filter to sort out products that are not available for order.
They also desire the ability to perform a search on the product name.  The filter and search box shall respect each other.
The filter checkbox and search box have already been stubbed in as show in the screenshot below:

![image](https://github.com/AvionSolutionsInc/NorthwindDbTest_CSharp/assets/165914496/cb84a900-2c6f-4e0b-aa6d-2155e84c7dc5)

#### Breakdown
* The Products page SHALL contain a "Show only available products" filter.
* The "Show only available products" filter SHALL not return any products that are not available (discontinued).
* The product results grid SHALL be updated when the filter checked state changes.
* The Products page SHALL contain a search box.
* The search box SHALL be used to search on product name only.
* The search button (magnifying glass) SHALL return all products that match both the set filter and search value.
* The entries count label SHALL accurately reflect the number of products returned by the search.

### Requirement #2
The customer would like to expand the application to include a Products Detail page. This page should contain, at a minimum, 
all product information as well as a list of all Orders the product is included in. The Product Detail page for a specific 
product will be accessible by clicking the product name link from the Products page grid. This page does not currently exist 
and will need to be created from scratch, as well as the linkage.

#### Breakdown
* The Products page SHALL provide links in the "Name" column to that product's detail page.
* The Product Detail page for a specific product SHALL contain all available Product data elements.
* The Product Detail page for a specific product SHALL contain a list of all Orders the Product is involved in.
* The Product Detail page for a specific product SHALL be read-only.