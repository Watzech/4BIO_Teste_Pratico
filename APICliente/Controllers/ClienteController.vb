Imports System.Web.Mvc
Imports Newtonsoft.Json

Public Class ClienteController
    Inherits Controller

    Private ReadOnly _clienteService As New ClienteService()
    Public Function Index() As ActionResult
        Return View(_clienteService.CarregarClientes())
    End Function

    Public Function Listar() As ActionResult
        Dim clientes As List(Of Cliente) = _clienteService.CarregarClientes()
        Return View(clientes)
    End Function

    Public Function FormCriar() As ActionResult
        Return View()
    End Function

    Public Function FormAtualizar() As ActionResult
        Return View()
    End Function

    Public Function ValidateFormAtualizar(cliente As Cliente) As ActionResult
        If cliente.Contatos Is Nothing OrElse cliente.Contatos.Count = 0 Then
            ModelState.AddModelError("Contatos", "É necessário adicionar pelo menos um contato.")
        End If
        If cliente.Enderecos Is Nothing OrElse cliente.Enderecos.Count = 0 Then
            ModelState.AddModelError("Enderecos", "É necessário adicionar pelo menos um endereço.")
        End If

        If ModelState.IsValid Then
            Criar(cliente)
            Return Index()
        End If

        Return View("FormCriar", cliente)
    End Function

    Public Function ValidateFormCriar(cliente As Cliente) As ActionResult
        If cliente.Contatos Is Nothing OrElse cliente.Contatos.Count = 0 Then
            ModelState.AddModelError("Contatos", "É necessário adicionar pelo menos um contato.")
        End If
        If cliente.Enderecos Is Nothing OrElse cliente.Enderecos.Count = 0 Then
            ModelState.AddModelError("Enderecos", "É necessário adicionar pelo menos um endereço.")
        End If

        If ModelState.IsValid Then
            Atualizar(cliente)
            Return Index()
        End If

        Return View("FormAtualizar", cliente)
    End Function

    <HttpGet>
    Public Function Find(id As Integer) As ActionResult
        Dim clientes As List(Of Cliente) = _clienteService.CarregarClientes()
        Dim clienteToFind As Cliente = clientes.Find(Function(p) p.Id = id)

        If clienteToFind Is Nothing Then
            Return HttpNotFound()
        End If

        Return View(clienteToFind)
    End Function

    <HttpPost>
    Public Function Criar(cliente As Cliente) As ActionResult
        Dim clientes As List(Of Cliente) = _clienteService.CarregarClientes()
        cliente.Id = (From cli In clientes
                      Order By cli.Id Descending).First.Id + 1
        clientes.Add(cliente)
        _clienteService.SalvarClientes(clientes)

        TempData("Message") = "Cliente incluído com sucesso."
        Return Index()
    End Function

    Public Function Atualizar(cliente As Cliente) As ActionResult
        Dim clientes As List(Of Cliente) = _clienteService.CarregarClientes()
        clientes.RemoveAll(Function(p) p.Id = cliente.Id)
        clientes.Add(cliente)
        _clienteService.SalvarClientes(clientes)

        TempData("Message") = "Cliente atualizado com sucesso."
        Return Index()
    End Function

    Public Function Remover(id As Integer) As ActionResult
        Dim clientes As List(Of Cliente) = _clienteService.CarregarClientes()
        Dim clienteToRemove As Cliente = clientes.FirstOrDefault(Function(c) c.Id = id)

        If clienteToRemove IsNot Nothing Then
            clientes.Remove(clienteToRemove)
            _clienteService.SalvarClientes(clientes)
            Return Json(New With {.success = True, .message = "Cliente removido com sucesso."})
        Else
            Return Json(New With {.success = False, .message = "Cliente não encontrado."})
        End If
    End Function

    Public Function Detalhes(id As Integer) As ActionResult
        Dim cliente As Cliente = _clienteService.CarregarClientes().FirstOrDefault(Function(c) c.Id = id)

        If cliente Is Nothing Then
            Return HttpNotFound("Cliente não encontrado.")
        End If

        Return View(cliente)
    End Function


End Class

