@Imports System.Web.Mvc
@ModelType IEnumerable(Of Cliente)
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <div class="container mt-3">
            <h1 class="text-center mb-5">Lista de Clientes</h1>

            <div class="text-left mb-3">
                <a href="@Url.Action("FormCriar", "Cliente")" class="btn btn-success">Adicionar Cliente</a>
            </div>

            <table class="table table-striped table-bordered">
                <thead class="thead-dark">
                    <tr>
                        <th></th>
                        <th>ID</th>
                        <th>Nome</th>
                        <th>Email</th>
                        <th>CPF</th>
                        <th>RG</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each cliente In Model
                        @<tr id="cliente-@cliente.Id">
                            <td>
                                <div class="dropdown">
                                    <button class="btn btn-secondary btn-sm dropdown-toggle" type="button" id="dropdownMenuButton-@cliente.Id" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        =
                                    </button>
                                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton-@cliente.Id">
                                        <a class="dropdown-item" href="@Url.Action("Detalhes", "Cliente", New With {.id = cliente.Id})">Ver Detalhes</a>
                                        <a class="dropdown-item" href="@Url.Action("FormCriar", "Cliente", New With {.id = cliente.Id})">Editar</a>
                                        <a class="dropdown-item text-danger" href="#" onclick="removerCliente(@cliente.Id)">Remover</a>
                                    </div>
                                </div>
                            </td>
                            <td>@cliente.Id</td>
                            <td>@cliente.Nome</td>
                            <td>@cliente.Email</td>
                            <td>@cliente.CPF</td>
                            <td>@cliente.RG</td>
                        </tr>
                    Next
                </tbody>
            </table>
        </div>
    </section>
</main>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" integrity="sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" integrity="sha384-h0AbiXch4ZDo7tp9hKZ4TsHbi047NrKGLO3SEJAg45jXxnGIfYzk4Si90RDIqNm1" crossorigin="anonymous"></script>
<script src="~/Scripts/cliente/index.js"></script>