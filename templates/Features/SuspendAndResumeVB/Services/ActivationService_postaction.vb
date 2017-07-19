'{**
'This code block includes the SuspendAndResumeService Instance in the method 
'`GetActivationHandlers()` in the ActivationService of your project.
'**}

'{[{
Imports Param_RootNamespace.Helpers
'}]}

Namespace Services
    Friend Class ActivationService
        Private Iterator Function GetActivationHandlers() As IEnumerable(Of ActivationHandler)
            '{[{
            Yield Singleton(Of SuspendAndResumeService).Instance
            '}]}
'{--{
            Exit Function'}--}
        End Function
    End Class
End Namespace
