$(document).ready(function (e) {
    $('#signInbtn').click(function () {
        var sPassword = $('#Password').val();
        if ($("#Password").val() == "") {
            alert('this fields is mandatory');
            e.preventDefault();
        }
        if (sPassword.length > 5) {
           // alert('Password must be greater than 5 :)');
            var Users = {
                "Password": $("#Password").val(),
            };
            $.ajax({
                type: "POST",
                //url: '~/Home/updatePassword1/~',
                data: JSON.stringify(Users),
                contentType: "application/json;charset=utf-8",
                processData: true,
                success: function (data, status, xhr) {
                   // alert("Password updated successfully");
                },
                error: function (xhr) {
                    alert("Invalid Password");
                }
            });
            return true;
        }
        else {
            alert('Invalid Password');
            return false;
        }

    });
});
// Function that validates email address through a regular expression.
function validateEmail(sEmail) {

    return /[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+/.test(sEmail); //return /[a-z]+@[a-z]+\.[a-z]+/.test(sEmail);
}