Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private ReadOnly _clienteService As New ClienteService()

    Public Function Index() As ActionResult
        Return View(_clienteService.CarregarClientes())
    End Function
End Class
