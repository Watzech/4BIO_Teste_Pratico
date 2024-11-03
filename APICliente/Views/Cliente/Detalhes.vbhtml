@ModelType Cliente

@Code
    ViewData("Title") = "Detalhes do Cliente"
End Code

<h1 class = "mb-5">Detalhes do Cliente</h1>

<div>
    <h2>@Model.Nome</h2>
    <p class = "mb-5">
        <strong>ID:</strong> @Model.Id<br />
        <strong>Email:</strong> @Model.Email<br />
        <strong>CPF:</strong> @Model.CPF<br />
        <strong>RG:</strong> @Model.RG
    </p>

    <h3>Contatos</h3>
    <ul class = "mb-5">
        @For Each contato In Model.Contatos
            @<li class = "mb-2">
                <strong>Tipo:</strong> @contato.Tipo <br />
                <strong>DDD:</strong> @contato.DDD <br />
                <strong>Telefone:</strong> @contato.Telefone
            </li>
        Next
    </ul>

    <h3>Endereços</h3>
    <ul class = "mb-5">
        @For Each endereco In Model.Enderecos
            @<li class = "mb-2">
                <strong>Tipo:</strong> @endereco.Tipo <br />
                <strong>CEP:</strong> @endereco.CEP <br />
                <strong>Logradouro:</strong> @endereco.Logradouro <br />
                <strong>Número:</strong> @endereco.Numero <br />
                <strong>Bairro:</strong> @endereco.Bairro <br />
                <strong>Cidade:</strong> @endereco.Cidade <br />
                <strong>Estado:</strong> @endereco.Estado
            </li>
        Next
    </ul>

    <a href="@Url.Action("Index", "Cliente")" class="btn btn-primary">Voltar para Lista de Clientes</a>
</div>
