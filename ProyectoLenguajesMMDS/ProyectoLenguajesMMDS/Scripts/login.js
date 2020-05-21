function login() {


    var login = {
  
        Username: $('#Username').val(),
        Password: $('#Password').val(),
    };

    if ($('#Username').val() != '' && $('#Password').val() != '') {
        $.ajax({
            url: "/Login/ValidateUserToLogin",
            data: JSON.stringify(login),
            type: "POST",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {

                alert("Bienvenido " + result.Role + ": " + result.Name);

            },
            error: function (errorMessage) {
                alert(errorMessage.responseText);
            }
        });

    } else {
        alert("Por favor ingrese los datos solicitados");
    }

}