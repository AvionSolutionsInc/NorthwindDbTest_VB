Imports NorthwindDbTest_VB.Models
Imports NorthwindDbTest_VB.ViewModels

Public Class ProductViewModelService
    Implements IViewModelService(Of ProductViewModel, Product)

    ''' <summary>
    ''' Creates a <see cref="ProductViewModel"/> from a provided <see cref="Product"/> model.
    ''' </summary>
    ''' <param name="source">The <see cref="Product"/> model.</param>
    ''' <returns></returns>
    Public Function CreateViewModel(source As Product) As ProductViewModel Implements IViewModelService(Of ProductViewModel, Product).CreateViewModel
        If source Is Nothing Then Throw New ArgumentNullException(NameOf(source))

        Return New ProductViewModel With
        {
            .Id = source.Id,
            .Name = source.Name,
            .IsAvailable = Not source.Discontinued,
            .QuantityPerUnit = source.QuantityPerUnit,
            .TotalUnitValue = source.UnitPrice * source.UnitsInStock,
            .UnitPrice = source.UnitPrice,
            .UnitsInStock = source.UnitsInStock
        }
    End Function

    ''' <summary>
    ''' Creates a collection of <see cref="ProductViewModel"/> from a provided collection of <see cref="Product"/> models.
    ''' </summary>
    ''' <param name="source">The collection of <see cref="Product"/> models.</param>
    ''' <returns></returns>
    Public Function CreateViewModel(source As IEnumerable(Of Product)) As IEnumerable(Of ProductViewModel) Implements IViewModelService(Of ProductViewModel, Product).CreateViewModel
        If source Is Nothing Then Throw New ArgumentNullException(NameOf(source))

        Return source.Select(Function(prod) CreateViewModel(prod))
    End Function
End Class
