Friend Interface IRepository(Of T As Class)
    '''' <summary>
    '''' Gets or sets the Northwind API endpoint used by this repository.
    '''' </summary>
    'ReadOnly Property Endpoint As String

    ''' <summary>
    ''' Get all <typeparamref name="T"/> from the API.
    ''' </summary>
    ''' <returns></returns>
    Function GetAll() As IEnumerable(Of T)

    ''' <summary>
    ''' Get the <typeparamref name="T"/> from the API with the associated ID.
    ''' </summary>
    ''' <param name="id">The ID of the record to retrieve.</param>
    ''' <returns></returns>
    Function GetById(id As Integer) As T
End Interface
