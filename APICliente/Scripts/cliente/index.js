$(document).ready(function () {
    window.removerCliente = function (clienteId) {
        if (confirm('Tem certeza que deseja remover este cliente?')) {
            $.ajax({
                url: '/Cliente/Remover/' + clienteId,
                type: 'POST',
                success: function (response) {
                    if (response.success) {
                        $('#cliente-' + clienteId).remove();
                    }
                },
                error: function () {
                    alert('Erro ao remover o cliente. Tente novamente.');
                }
            });
        }
    };
});
