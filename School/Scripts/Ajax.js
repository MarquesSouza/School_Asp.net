$(document).ready(function () {
    $("#Uf").change(function () {
        listaCidade($(this).val());
    });
});
//chamada ajax para a Action ListaCidade
//passando como parâmetro a Estado selecionado
function listaCidade(uf) {

    $.getJSON('<%= Url.Action("cities/listcities") %>/' + uf, listaCidadeCallBack);
}
//função que irá ser chamada quando terminar
//a chamada ajax
function listaCidadeCallBack(json) {
    //Limpar os itens que são maiores que 0
    //Ou seja: não retirar o primeiro item
    $("#Cidades :gt(0)").remove();
    $(json).each(function () {
        //adicionando as opções de acordo com o retorno
        $("#Cidades").append("<option value='" + this.Id + "'>" + this.Nome + "</option>");
    });
}