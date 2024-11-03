@ModelType Cliente
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<h1 class="text-center mb-5">Adicionar novo Cliente</h1>
@Using Html.BeginForm("ValidateFormAtualizar", "Cliente", FormMethod.Post)
    @Html.AntiForgeryToken()

    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

    @For Each prop In GetType(Cliente).GetProperties()
        If prop.Name <> "Id" And prop.Name <> "Contatos" And prop.Name <> "Enderecos" Then
            @<div class="form-group mt-2">
                @Html.Label(prop.Name + ":", New With {.class = "control-label"})
                @If prop.Name Is "CPF" Or prop.Name Is "RG" Then
                    @Html.TextBox(prop.Name, Nothing, New With {.class = "form-control", .type = "number"})
                    @Html.ValidationMessage(prop.Name, "", New With {.class = "text-danger"})
                Else
                    @Html.TextBox(prop.Name, Nothing, New With {.class = "form-control"})
                    @Html.ValidationMessage(prop.Name, "", New With {.class = "text-danger"})
                End If
            </div>
        End If
    Next

    @<div class="d-flex align-items-center mt-5">
        <h3 class="me-3 mb-0">Contatos</h3>
        <button type="button" id="add-contact" class="btn btn-outline-primary mt-2">Adicionar Contato</button>
    </div>
    @Html.ValidationMessage("Contatos", "", New With {.class = "text-danger"})
    @<div id="contatos-section">
        @* Contatos *@
    </div>

    @<div class="d-flex align-items-center mt-5">
        <h3 class="me-3 mb-0">Endereços</h3>
        <button type="button" id="add-address" class="btn btn-outline-primary mt-2">Adicionar Endereço</button>
    </div>
    @Html.ValidationMessage("Enderecos", "", New With {.class = "text-danger"})
    @<div id="enderecos-section">
        @* Endereços *@
    </div>
    @<br />

    @<div class="mt-4">
        <button type="submit" class="btn btn-primary mt-3">Salvar</button>
        <a href="@Url.Action("Index", "Cliente")" class="btn btn-secondary mt-3">Cancelar</a>
    </div>
End Using
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js" integrity="sha384-b/U6ypiBEHpOf/4+1nzFpr53nxSS+GLCkfwBdFNTxtclqqenISfwAzpKaMNFNmj4" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" integrity="sha384-h0AbiXch4ZDo7tp9hKZ4TsHbi047NrKGLO3SEJAg45jXxnGIfYzk4Si90RDIqNm1" crossorigin="anonymous"></script>
<script src="~/Scripts/cliente/clienteForm.js"></script>