Namespace Models
    <Serializable>
    Public Class Product
        Public Property Id As Integer
        Public Property SupplierId As Integer
        Public Property CategoryId As Integer
        Public Property QuantityPerUnit As String
        Public Property UnitPrice As Decimal
        Public Property UnitsInStock As Integer
        Public Property UnitsOnOrder As Integer
        Public Property ReorderLevel As Integer
        Public Property Discontinued As Boolean
        Public Property Name As String
        Public Property Supplier As Supplier
        Public Property Category As Category
    End Class
End Namespace
