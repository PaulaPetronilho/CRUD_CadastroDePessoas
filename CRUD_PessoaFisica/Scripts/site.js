$(document).ready(function () {
    //Mascara para deixar todas as primeiras letras do nome maiusculas
    document.getElementById("nomeCompleto").addEventListener("input", function () {
        var texto = this.value.toLowerCase();                                               // Converte todo o texto para minúsculas
        texto = texto.replace(/(?:^|\s)\S/g, function (a) { return a.toUpperCase(); });     // Capitaliza a primeira letra de cada palavra
        this.value = texto;
    });
    
    //Mascara para data de nascimento
    $('#dataNascimento').mask('00/00/0000');
    //Mascara para valor da renda
    $('#valor').mask('000.000.000,00', { reverse: true });
    //Mascara para CPF
    $('#cpf').mask('000.000.000-00', { reverse: true });

});

function confirmExclusao() {
    if (confirm("Tem certeza que deseja excluir?")) {
        return true; // Continua com o envio do formulário
    } else {
        return false; // Cancela o envio do formulário
    }
}