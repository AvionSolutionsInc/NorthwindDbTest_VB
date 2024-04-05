Imports Microsoft.AspNet.FriendlyUrls

Public Class RouteConfig
    Public Shared Sub RegisterRoutes(routes As RouteCollection)
        Dim settings As New FriendlyUrlSettings()
        settings.AutoRedirectMode = RedirectMode.Permanent
        routes.EnableFriendlyUrls(settings)
    End Sub
End Class
