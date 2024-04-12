<%@ Page Title="Home" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="NorthwindDbTest_VB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row">
            <h1>Northwind DB Test</h1>
            <p class="lead">Welcome to the Avion Solutions, Inc. Northwind DB Test!</p>
        </section>

        <div class="row">
            <section class="col-12">
                <h3>About this test</h3>
                <p>
                    What you see here is the beginning of a very simple data-driven business web application similar in nature to what
                    Avion Solutions, Inc. maintains for the US Army.  Our goal is to gather information about how you interpret requirements
                    and go about implementing them.  We will look at the code you write and the end product to help drive conversation
                    during a possible interview.  This test consists of implementing two requirements that are detailed below.
                </p>
            </section>
            <section class="col-12 mt-3">
                <h3>JavaScript Libraries</h3>
                <p>
                    The following JavaScript libraries are employed in this application:
                </p>
                <ul>
                    <li><a href="https://api.jquery.com/" target="_blank" rel="noreferrer">jQuery 3.7.1</a>&nbsp<i class="bi bi-box-arrow-up-right" style="font-size: 0.75rem;"></i></li>
                    <li><a href="https://getbootstrap.com/docs/5.2/getting-started/introduction/" target="_blank" rel="noreferrer">Bootstrap 5.3.3</a>&nbsp<i class="bi bi-box-arrow-up-right" style="font-size: 0.75rem;"></i></li>
                    <li><a href="https://icons.getbootstrap.com/" target="_blank" rel="noreferrer">Bootstrap Icons 1.11.3</a>&nbsp<i class="bi bi-box-arrow-up-right" style="font-size: 0.75rem;"></i></li>
                </ul>
            </section>
            <section class="col-12 mt-3">
                <h3>Northwind data</h3>
                <p>
                    This web application utilizes the <a href="https://northwind.vercel.app/" target="_blank" rel="noreferrer">Northwind JSON Server API</a>&nbsp<i class="bi bi-box-arrow-up-right" style="font-size: 0.75rem;"></i> as its data source.
                    The DataAccess folder in the project contains a helper class with the accessible data endpoints as well as a repository for accessing Product data.  
                    We strongly encourage you to browse the following available endpoints to view the available data elements as well as their relationship to one another:
                </p>
                <ul>
                    <li><a href='<%= NorthwindDbTest_VB.NorthwindApiEndpoints.Categories %>' target="_blank" rel="noreferrer">Categories</a>&nbsp<i class="bi bi-box-arrow-up-right" style="font-size: 0.75rem;"></i></li>
                    <li><a href='<%= NorthwindDbTest_VB.NorthwindApiEndpoints.Customers %>' target="_blank" rel="noreferrer">Customers</a>&nbsp<i class="bi bi-box-arrow-up-right" style="font-size: 0.75rem;"></i></li>
                    <li><a href='<%= NorthwindDbTest_VB.NorthwindApiEndpoints.Orders %>' target="_blank" rel="noreferrer">Orders</a>&nbsp<i class="bi bi-box-arrow-up-right" style="font-size: 0.75rem;"></i></li>
                    <li><a href='<%= NorthwindDbTest_VB.NorthwindApiEndpoints.Products %>' target="_blank" rel="noreferrer">Products</a>&nbsp<i class="bi bi-box-arrow-up-right" style="font-size: 0.75rem;"></i></li>
                    <li><a href='<%= NorthwindDbTest_VB.NorthwindApiEndpoints.Suppliers %>' target="_blank" rel="noreferrer">Suppliers</a>&nbsp<i class="bi bi-box-arrow-up-right" style="font-size: 0.75rem;"></i></li>
                </ul>
            </section>
            <section class="col-12 mt-3">
                <h3>Requirement #1</h3>
                <h6>Summary</h6>
                <p>
                    The Products page currently loads all products in the database.  The customer would like to expand the Products page to include a filter to sort out products that are not available for order.
                    They also desire the ability to perform a search on the product name.  The filter and search box shall respect each other.
                    The filter checkbox and search box have already been stubbed in as show in the screenshot below:
                </p>
                <figure class="figure">
                    <img src="Images/req1_1.png" class="figure-img img-fluid img-bordered rounded" />
                    <figcaption class="figure-caption text-center">Stubbed in filter and search box on Product page</figcaption>
                </figure>
                <h6>Breakdown</h6>
                <ul>
                    <li>The Products page <strong>SHALL</strong> contain a "Show only available products" filter.</li>
                    <li>The "Show only available products" filter <strong>SHALL</strong> not return any products that are not available (discontinued).</li>
                    <li>The product results grid <strong>SHALL</strong> be updated when the filter checked state changes.</li>
                    <li>The Products page <strong>SHALL</strong> contain a search box.</li>
                    <li>The search box <strong>SHALL</strong> be used to search on product name only.</li>
                    <li>The search button (magnifying glass) <strong>SHALL</strong> return all products that match both the set filter and search value.</li>
                    <li>The entries count label <strong>SHALL</strong> accurately reflect the number of products returned by the search.</li>
                </ul>
                
            </section>
            <section class="col-12 mt-3">
                <h3>Requirement #2</h3>
                <h6>Summary</h6>
                <p>
                    The customer would like to expand the application to include a Products Detail page.  This page should contain, at a minimum, all product information
                    as well as a list of all Orders the product is included in.  The Product Detail page for a specific product will be accessible by clicking the product name
                    link from the Products page grid.  This page does not currently exist and will need to be created from scratch, as well as the linkage.
                </p>
                <h6>Breakdown</h6>
                <ul>
                    <li>The Products page <strong>SHALL</strong> provide links in the "Name" column to that product's detail page.</li>
                    <li>The Product Detail page for a specific product <strong>SHALL</strong> contain all available Product data elements.</li>
                    <li>The Product Detail page for a specific product <strong>SHALL</strong> contain a list of all Orders the Product is involved in.</li>
                    <li>The Product Detail page for a specific product <strong>SHALL</strong> be read-only.</li>
                </ul>
            </section>
            <section class="col-12 mt-3">
                <h3>How to submit</h3>
                <p>
                    After you have finished work on the project, please email a link to your GitHub repository containing your work to:
                </p>
                <address>
                    <a href="mailto:candidatesubmissions@avionsolutions.com">candidatesubmissions@avionsolutions.com</a><br />
                </address>
            </section>            
         
        </div>
    </main>

</asp:Content>
