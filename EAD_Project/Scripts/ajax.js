
$(document).ready(function (e) {
    $("#btnAdd").click(function () {

        var SignUpModel = {
            "Email": $("#Email").val(),
            "Password": $("#Password").val(),
        };
        $.ajax({
            type: "POST",
            url: '~/api/Values/PostPersonalDetails',
            data: JSON.stringify(SignUpModel),
            contentType: "application/json;charset=utf-8",
            processData: true,
            success: function (data, status, xhr) {
                alert("The result is : " + status);
            },
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });

    });

});