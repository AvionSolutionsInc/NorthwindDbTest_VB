''' <summary>
''' A simple interface for converting source models into view models.
''' </summary>
''' <typeparam name="TResult">The view model type that is returned.</typeparam>
''' <typeparam name="TSource">The model used as a source to construct the result.</typeparam>
Friend Interface IViewModelService(Of TResult As Class, TSource As Class)
    Function CreateViewModel(source As TSource) As TResult
    Function CreateViewModel(source As IEnumerable(Of TSource)) As IEnumerable(Of TResult)
End Interface
