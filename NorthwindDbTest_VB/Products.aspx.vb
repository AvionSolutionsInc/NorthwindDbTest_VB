Imports NorthwindDbTest_VB.Models

Public Class Products
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            LoadProducts()
        End If
    End Sub

    ''' <summary>
    ''' Load all products into the grid.
    ''' </summary>
    Private Sub LoadProducts()
        Using productRepo As ProductsRepository = New ProductsRepository()
            Dim productViewModelService As ProductViewModelService = New ProductViewModelService()
            Dim products As IEnumerable(Of Product) = productRepo.GetAll()

            If products IsNot Nothing Then
                gvProducts.DataSource = productViewModelService.CreateViewModel(products)
                gvProducts.DataBind()
            End If
        End Using
    End Sub

    Protected Sub gvProducts_PreRender(sender As Object, e As EventArgs)
        Dim gv As GridView = CType(sender, GridView)

        If (gv.ShowHeader AndAlso gv.Rows.Count > 0) OrElse gv.ShowHeaderWhenEmpty Then
            ' Force GridView to use <thead> instead of <tbody>
            ' This allows the Bootstrap styles to be applied appropriately
            gv.HeaderRow.TableSection = TableRowSection.TableHeader
        End If

        If gv.ShowFooter AndAlso gv.Rows.Count > 0 Then
            ' Force GridView to use <tfoot> instead of <tbody>
            ' This allows the Bootstrap styles to be applied appropriately
            gv.FooterRow.TableSection = TableRowSection.TableFooter
        End If
    End Sub

    Protected Sub gvProducts_DataBound(sender As Object, e As EventArgs)
        Dim gv As GridView = CType(sender, GridView)

        lblRecordCount.Text = $"Showing 1 to {gv.Rows.Count} of {gv.Rows.Count} entries"
    End Sub
End Class