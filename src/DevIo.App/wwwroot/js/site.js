function AjaxModal() {
    $(document).ready(function () {
        $(function () {
            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click",
                function (e) {
                    $('#myModalContent').load(this.href,
                        function () {
                            $('#myModal').modal({
                                keyboard: true
                            },
                                'show');
                            bindForm(this);
                        });
                    return false;
                });
        });


        function bindForm(dialog) {
            $('form', dialog).submit(function () {
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    success: function (result) {
                        if (result.success) {
                            $('#myModal').modal('hide');
                            $('#EnderecoTarget').load(result.url);

                        } else {
                            $('#myModalContent').html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            });
        }
    });
}

function BuscaCep() {
    $(document).ready(function () {
        function limpa_formulario_cep() {
            //Limpa os valores do formulario
            $("#Endereco_Logradouro").val("");
            $("#Endereco_Bairro").val("");
            $("#Endereco_Cidade").val("");
            $("#Endereco_Estado").val("");
        }

        //Quando o cep perde o foco
        $("#Endereco_Cep").blur(function () {

            //nova variavel cep somente com digitos
            var cep = $(this).val().replace(/\D/g, '');

            //Verifica se o campo cep tem valor informado
            if (cep != "") {

                //Expressao regular para validar cep.

                var validacep = /^[0-9]{8}$/;

                //valida o formato do cep.
                if (validacep.test(cep)) {

                    //preenche os campos com ... enquando consulta o webservice
                    $("#Endereco_Logradouro").val("...");
                    $("#Endereco_Bairro").val("...");
                    $("#Endereco_Cidade").val("...");
                    $("#Endereco_Estado").val("...");


                    //Consulta o webservice viacep.com.br
                    $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?",
                        function (dados) {
                            if (!("erro" in dados)) {
                                $("#Endereco_Logradouro").val(dados.logradouro);
                                $("#Endereco_Bairro").val(dados.bairro);
                                $("#Endereco_Cidade").val(dados.localidade);
                                $("#Endereco_Estado").val(dados.uf);
                            }
                            else {
                                //cep pesquisado nao foi encontrado
                                limpa_formulario_cep();
                                alert("Cep não encontrado.");
                            }
                        });
                }
                else {
                    // cep é inválido
                    limpa_formulario_cep();
                    alert("Cep em formáto inválido");
                }
            }
            else {
                //Cep sem valor limpa o formulario
                limpa_formulario_cep();
            }
        });
    });
}
