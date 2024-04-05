Imports NorthwindDbTest_VB.Models

Friend Class ProductsRepository
    Inherits BaseRepository(Of Product)

    ''' <summary>
    ''' Gets or sets the Northwind API endpoint used by this repository.
    ''' </summary>
    ''' <returns></returns>
    Public Overrides ReadOnly Property Endpoint As String
        Get
            Return NorthwindApiEndpoints.Products
        End Get
    End Property
End Class
