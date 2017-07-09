$(document).ready(function (e) {
    $('#billTo').click(function () {
            var Users = {
                "Display_Name": $("#Display_Name").val(),
                "User_Name": $("#User_Name").val(),
                "Password": $("#Password").val(),
                "confirm_password": $("#confirm_password").val(),
                "Company_Name": $("#Company_Name").val(),
                "Email": $("#Email").val(),
                "Title": $("#Title").val(),
                "First_Name": $("#First_Name").val(),
                "Middle_Name": $("#Middle_Name").val(),
                "Last_Name": $("#Last_Name").val(),
                "Address_1": $("#Address_1").val(),
                "Address_2": $("#Address_2").val(),
                "Zip": $("#Zip").val(),
                "Country": $("#Country").val(),
                "State": $("#State").val(),
                "Phone1": $("#Phone1").val(),
                "Phone2": $("#Phone2").val(),
                "Mobile_Phone": $("#Mobile_Phone").val(),
                "Fax": $("#Fax").val(),
                "message": $("#message").val(),
                "Shipping": $("#Shipping").val()
            };
            $.ajax({
                type: "POST",
                url: '/Home/Bill_To',
                data: JSON.stringify(Users),
                contentType: "application/json;charset=utf-8",
                processData: true,
                success: function (data, status, xhr) {

                    alert("U have checked out successfully !!! ");
                    location.href = "/Home/NormalUser"
                },
                error: function (xhr) {
                    alert("CheckOut unsuccessful!!! Try Again ");
                }
            });
            return true;
     
    });
});
// Function that validates email address through a regular expression.
//function validateEmail(sEmail) {

//    return /[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+/.test(sEmail);// return /[a-z]+@[a-z]+\.[a-z]+/.test(sEmail);
//}