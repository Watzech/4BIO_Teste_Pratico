Imports System.IO
Imports Newtonsoft.Json

Public Class ClienteService
    Private ReadOnly _dataPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/db.json")

    Public Function CarregarClientes() As List(Of Cliente)
        If Not File.Exists(_dataPath) Then
            Return New List(Of Cliente)()
        End If

        Dim jsonData As String = File.ReadAllText(_dataPath)
        Return JsonConvert.DeserializeObject(Of List(Of Cliente))(jsonData)
    End Function

    Public Sub SalvarClientes(clientes As List(Of Cliente))
        Dim jsonData As String = JsonConvert.SerializeObject(clientes, Formatting.Indented)
        System.IO.File.WriteAllText(_dataPath, jsonData)
    End Sub
End Class
