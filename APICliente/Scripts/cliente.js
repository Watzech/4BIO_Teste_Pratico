$(document).ready(function () {
    //Remoção de Cliente na grid principal
    window.removerCliente = function (clienteId) {
        if (confirm('Tem certeza que deseja remover este cliente?')) {
            $.ajax({
                url: '/Cliente/Remover/' + clienteId,
                type: 'POST',
                success: function (response) {
                    if (response.success) {
                        $('#cliente-' + clienteId).remove();
                        alert(response.message);
                    } else {
                        alert(response.message);
                    }
                },
                error: function () {
                    alert('Erro ao remover o cliente. Tente novamente.');
                }
            });
        }
    };
});
