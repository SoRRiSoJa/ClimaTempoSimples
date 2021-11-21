$('#Cidades').change(
    function () {
        var val1 = $('option:selected').val();
        var nomeCidade = $('option:selected').text(); 
        var url = '/Home/'
        $.ajax({
            type: 'POST', 
            url: url + "ObeterPrevisaoSemanal",
            data: {
                idCidade: val1
            },
            dataType: "json",
            traditional: true,
            contenttype: "application/json; charset=utf-8",
            success: function (result) {
                if (result != null) {
                    var titulo= '<div style="width: 100%; text-align:center"><strong>Previsão para os próximos sete dias na cidade de  ' + nomeCidade + '</strong></div>';
                    var newHtml = "";
                    $("#cidadeEscolhida").html(titulo);
                    $.each(result, function (index, previsao) {
                        newHtml += '<div class="quadrinho">'
                        newHtml += '        <div class="quadrinhoInterno">'
                        newHtml += '            <div style="width: 100%; text-align:center; color: white;">' + previsao.DiaSemana + '</div>'
                        newHtml += '        </div>'
                        newHtml += '        <div>'
                        newHtml += '            <div style="width: 100%; text-align:center">Mínima ' + previsao.Clima + '</div>'
                        newHtml += '            <div style="width: 100%; text-align:center">Mínima ' + previsao.TemperaturaMinima + '°C </div>'
                        newHtml += '            <div style="width: 100%; text-align: center;">Máxima' + previsao.TemperaturaMaxima + '°C </div>'
                        newHtml += '        </div>'
                        newHtml += '    </div>'
                    });
                    $("#info").html(newHtml);
                }
            },
            complete: function (result) {
              
            }
        });
    }
);
