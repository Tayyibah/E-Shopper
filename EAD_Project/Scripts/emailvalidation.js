﻿$(document).ready(function (e) {
    $('#btnAdd').click(function () {
        var sEmail = $('#Login').val();
        var sPassword = $('#Password').val();
        if ($.trim(sEmail).length == 0 || $("#Password").val() == "" ) {
            alert('All fields are mandatory');
           // e.preventDefault();
        }
        if (sPassword.length < 5) {
            alert('Password must be greater than 5 :)');
           // e.preventDefault();
        }
        if (validateEmail(sEmail)) {
           // alert('Nice!! your Email is valid, now you can continue..');
            var Users = {
                "Login": $("#Login").val(),
                "Password": $("#Password").val(),
            };
            $.ajax({
                type: "POST",
                url: '~/api/Values/PostPersonalDetails',
                data: JSON.stringify(Users),
                contentType: "application/json;charset=utf-8",
                processData: true,
                success: function (data, status, xhr) {
                    alert("The result is : " + status);
                },
                error: function (xhr) {
                    alert('Email Address Already Exists');
                    //alert(xhr.responseText);
                }
            });
            return true;
        }
        else {
            alert('Invalid Email Address');
            return false;
        }

    });
});
// Function that validates email address through a regular expression.
function validateEmail(sEmail) {

    return /[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+/.test(sEmail);
    //return /[a-z]+@[a-z]+\.[a-z]+/.test(sEmail);
}