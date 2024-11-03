var contactIndex = 0;
var addressIndex = 0;

document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("add-contact").addEventListener("click", function () {
    const contactHtml = `
        <div class="d-inline-block" style="max-width: 400px;">
            <div class="contact-item mt-3 p-3 border border-light rounded shadow-sm" id="contact-${contactIndex}">
                <h4 class="mb-3">Cont. ${contactIndex + 1}</h4>
                <div class="form-group mb-2">
                    <label for="Contatos(${contactIndex}]).Tipo">Tipo:</label>
                    <input type="text" name="Contatos(${contactIndex}).Tipo" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Contatos(${contactIndex}).DDD">DDD:</label>
                    <input type="text" name="Contatos(${contactIndex}).DDD" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Contatos(${contactIndex}).Telefone">Telefone:</label>
                    <input type="text" name="Contatos(${contactIndex}).Telefone" class="form-control" />
                </div>
                <button type="button" onclick="removeElement('contact-${contactIndex}', 'C')" class="btn btn-danger mt-2">Remover</button>
            </div>
        </div>
    `;
    document.getElementById("contatos-section").insertAdjacentHTML("beforeend", contactHtml);
    contactIndex++;
});

    document.getElementById("add-address").addEventListener("click", function () {
        const addressHtml = `
        <div class="d-inline-block" style="max-width: 400px;">
            <div class="address-item mt-3 p-3 border border-light rounded shadow-sm" id="address-${addressIndex}">
                <h4>End. ${addressIndex + 1}</h4>
                <div class="form-group mb-2">
                    <label for="Enderecos(${addressIndex}).Tipo">Tipo:</label>
                    <input type="text" name="Enderecos(${addressIndex}).Tipo" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Enderecos(${addressIndex}).CEP">CEP:</label>
                    <input type="text" name="Enderecos(${addressIndex}).CEP" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Enderecos(${addressIndex}).Logradouro">Logradouro:</label>
                    <input type="text" name="Enderecos(${addressIndex}).Logradouro" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Enderecos(${addressIndex}).Numero">Número:</label>
                    <input type="text" name="Enderecos(${addressIndex}).Numero" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Enderecos(${addressIndex}).Bairro">Bairro:</label>
                    <input type="text" name="Enderecos(${addressIndex}).Bairro" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Enderecos(${addressIndex}).Complemento">Complemento:</label>
                    <input type="text" name="Enderecos(${addressIndex}).Complemento" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Enderecos(${addressIndex}).Cidade">Cidade:</label>
                    <input type="text" name="Enderecos(${addressIndex}).Cidade" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Enderecos(${addressIndex}).Estado">Estado:</label>
                    <input type="text" name="Enderecos(${addressIndex}).Estado" class="form-control" />
                </div>
                <div class="form-group mb-2">
                    <label for="Enderecos(${addressIndex}).Referencia">Referência:</label>
                    <input type="text" name="Enderecos(${addressIndex}).Referencia" class="form-control" />
                </div>
                <button type="button" onclick="removeElement('address-${addressIndex}', 'E')" class="btn btn-danger mt-2">Remover</button>
            </div>
        </div>
    `;
        document.getElementById("enderecos-section").insertAdjacentHTML("beforeend", addressHtml);
        addressIndex++;
    });
});

function removeElement(id, type) {
    const element = document.getElementById(id);
    if (element) {
        element.remove();
        if (type == 'C') contactIndex--;
        if (type == 'E') addressIndex--;
    }
}
