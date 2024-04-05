Public Module NorthwindApiEndpoints
    Private ReadOnly _baseUrl As String = "https://northwind.vercel.app/api"

    ''' <summary>
    ''' The Northwind API endpoint that returns all products as JSON.
    ''' </summary>
    Public ReadOnly Products As String = $"{_baseUrl}/products"

    ''' <summary>
    ''' The Northwind API endpoint that returns all orders as JSON.
    ''' </summary>
    Public ReadOnly Orders As String = $"{_baseUrl}/orders"

    ''' <summary>
    ''' The Northwind API endpoint that returns all categories as JSON.
    ''' </summary>
    Public ReadOnly Categories As String = $"{_baseUrl}/categories"

    ''' <summary>
    ''' The Northwind API endpoint that returns all suppliers as JSON.
    ''' </summary>
    Public ReadOnly Suppliers As String = $"{_baseUrl}/suppliers"

    ''' <summary>
    ''' The Northwind API endpoint that returns all customers as JSON.
    ''' </summary>
    Public ReadOnly Customers As String = $"{_baseUrl}/customers"
End Module
