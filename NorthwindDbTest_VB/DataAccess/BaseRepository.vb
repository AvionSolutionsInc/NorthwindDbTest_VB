Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Threading
Imports System.Threading.Tasks

Friend MustInherit Class BaseRepository(Of T As Class)
    Implements IDisposable, IRepository(Of T)

    ''' <summary>
    ''' The <see cref="HttpClient"/> used to make API calls.
    ''' </summary>
    Protected _client As HttpClient

    ''' <summary>
    ''' The <see cref="TaskFactory"/> used to make async calls in a synchronous method.
    ''' </summary>
    Protected _taskFactory As TaskFactory

    Public Sub New()
        _client = New HttpClient()
        _taskFactory = New TaskFactory(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, TaskScheduler.Default)
    End Sub

    Public MustOverride ReadOnly Property Endpoint As String

    ''' <summary>
    ''' Get all <typeparamref name="T"/> from the API.
    ''' </summary>
    ''' <returns></returns>
    Public Overridable Function GetAll() As IEnumerable(Of T) Implements IRepository(Of T).GetAll
        Return GetDataFromEndpoint(Of IEnumerable(Of T))(Endpoint)
    End Function

    ''' <summary>
    ''' Get the <typeparamref name="T"/> from the API with the associated ID.
    ''' </summary>
    ''' <param name="id">The ID of the record to retrieve.</param>
    ''' <returns></returns>
    Public Overridable Function GetById(id As Integer) As T Implements IRepository(Of T).GetById
        Return GetDataFromEndpoint(Of T)($"{Endpoint}/{id}")
    End Function

    ''' <summary>
    ''' Make an API endpoint call and return the data that was retrieved.
    ''' </summary>
    ''' <typeparam name="TReturn">The return type of the data.</typeparam>
    ''' <param name="endpoint">The API endpoint to call.</param>
    ''' <returns>All data returned from the API endpoint call as <typeparamref name="TReturn"/>.</returns>
    Protected Function GetDataFromEndpoint(Of TReturn As Class)(endpoint As String) As TReturn
        Dim data As TReturn = Nothing

        Using response As HttpResponseMessage = _taskFactory.RunAsyncWithResult(Function() _client.GetAsync(endpoint))
            If response.IsSuccessStatusCode Then
                Dim json As String = _taskFactory.RunAsyncWithResult(Function() response.Content.ReadAsStringAsync())

                If Not String.IsNullOrEmpty(json) Then
                    data = JsonConvert.DeserializeObject(Of TReturn)(json)
                End If
            End If
        End Using

        Return data
    End Function

#Region "IDisposable Pattern"

    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
                If _client IsNot Nothing Then
                    _client.Dispose()
                End If
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class
