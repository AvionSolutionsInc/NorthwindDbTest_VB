Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks

''' <summary>
''' A set of extension methods for working with the <see cref="TaskFactory"/>.
''' </summary>
Public Module TaskFactoryExtensions
    ''' <summary>
    ''' Creates, starts, and returns the results of a <see cref="Task(Of TResult)"/>.
    ''' </summary>
    ''' <typeparam name="TResult">The return type.</typeparam>
    ''' <param name="factory">The <see cref="TaskFactory"/> instance to use.</param>
    ''' <param name="func">A function delegate to run in the task.</param>
    ''' <returns></returns>
    <Extension()>
    Public Function RunAsyncWithResult(Of TResult)(factory As TaskFactory, func As Func(Of Task(Of TResult)))
        Return factory.
            StartNew(func).
            Unwrap().
            GetAwaiter().
            GetResult()
    End Function
End Module
