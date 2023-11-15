function ValidarFormulario() {
    var elementosRadio = document.querySelectorAll('input[type="radio"]');

    for (var i = 0; i < elementosRadio; i++) {
        if (!elementosRadio[i].checked) {
            alert('Por favor, selecione uma resposta para cada pergunta.');
            return false; // Impede o envio do formulário se não estiver completamente preenchido
        }
    }
    return true; // Permite o envio do formulário se todas as respostas estiverem selecionadas
}