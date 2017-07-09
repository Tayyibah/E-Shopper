$(document).ready(function (e) {
    $('#btnAddf').click(function () {
        var sEmail = $('#Login').val();
        if ($.trim(sEmail).length == 0 ) {
            alert('All fields are mandatory');
            return false;
        }
        if (validateEmail(sEmail)) {
            var Users = {
                "Login": $("#Login").val(),
            };
            $.ajax({
                type: "POST",
                url: '~/api/Values/forgetPassword',
                data: JSON.stringify(Users),
                contentType: "application/json;charset=utf-8",
                processData: true,
                success: function (data, status, xhr) {
                    alert("An Email is sent to ur email  "+'\n'+"Proceed further accordingly :)");
                },
                error: function (xhr) {
                    alert("An Email is sent to ur email  " + '\n' + "Proceed further accordingly :)");
                  //  alert(xhr.responseText);
                }
            });
            return true;
        }
        else {
            alert('Invalid Email Address ,try again :) ');
            return false;
        }

        return false;
    });
});
// Function that validates email address through a regular expression.
function validateEmail(sEmail) {
    //bsef14a011@pucit.edu.pk
    return /[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+/.test(sEmail);
    //return /[a-z]+@[a-z]+\.[a-z]+/.test(sEmail);
}