Imports System.ComponentModel.DataAnnotations

Public Class Cliente
    Public Property Id As Integer

    <Required(ErrorMessage:="O nome é obrigatório.")>
    Public Property Nome As String

    <Required(ErrorMessage:="O Email é obrigatório.")>
    <EmailAddress(ErrorMessage:="Email inválido.")>
    Public Property Email As String

    <Required(ErrorMessage:="O CPF é obrigatório")>
    <StringLength(11, ErrorMessage:="O CPF deve ter 11 dígitos.")>
    Public Property CPF As String

    <Required(ErrorMessage:="O RG é obrigatório")>
    <StringLength(11, ErrorMessage:="O CPF deve ter 9 dígitos.")>
    Public Property RG As String

    <MinLength(1, ErrorMessage:="É necessário adicionar pelo menos um contato")>
    Public Property Contatos As List(Of Contato)

    <MinLength(1, ErrorMessage:="É necessário adicionar pelo menos um endereço")>
    Public Property Enderecos As List(Of Endereco)
End Class
