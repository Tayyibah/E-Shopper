////$(document).ready(function (e) {
////    $('#btnSave1').click(function () {
        
////        var files = $("#myfile").get(0).files;
////        var Users = {
////            "email": $("#email").val(),
////            "name": $("#name1").val(),
////            "Designation": $("#Designation").val(),
////            "password": $("#password").val(),
////            "cn_password": $("#cn_password").val(),
////            "oldPicName": $("#txtPictureName").val()
            
////        };
////        $.ajax({
////            type: "POST",
////            url: '/Home/SaveUsers',
////            data: JSON.stringify(Users),
////            contentType: "application/json;charset=utf-8",
////            processData: true,
////            success: function (data, status, xhr) {

////                alert("thanks for registering!!! !!! ");
////                location.href = "/Home/NormalUser"
////            },
////            error: function (xhr) {
////                alert("registeration unsuccessful!!! Try Again ");
////            }
////        });
////        return true;

////    });
////});
       





////var MyApp = {};

////MyApp = (function () {

////    function SaveProduct() {

////        var data = new FormData();

////        var email = $("#email").val();
////        var name = $("#name1").val();
////        var Designation = $("#Designation").val();
////        var password = $("#password1").val();
////        var cn_password = $("#cn_password").val();
////        var oldPicName = $("#txtPictureName").val();

////        data.append("name", name);
////        data.append("email", email);
////        data.append("Designation", Designation);
////        data.append("password1", password);
////        data.append("cn_password", cn_password);
////        data.append("PictureName", oldPicName);


////        var files = $("#myfile").get(0).files;
////        if (files.length > 0) {
////            data.append("Image", files[0]);
////        }
////    var settings = {
////        type: "POST",
////        url: '/Home/SaveUsers',
////        contentType: "application/json;charset=utf-8",
////        processData: true,
////        data: data,
////        success: function (data, status, xhr) {

////            alert("record is saved !!! ");
////            location.href = "/Home/NormalUser"
////        },
////        error: function (xhr) {
////            alert("record is saved unsuccessfully!!! Try Again ");
////        }
////    };

////    $.ajax(settings);
////}
////    //    var settings = {
////    //        type: "POST",
////    //        url: '/Home/SaveUsers',
////    //       // data: JSON.stringify(Users),
////    //        contentType: "application/json;charset=utf-8",
////    //        processData: true,
////    //        contentType: false,
////    //        data: data,
////    //            success: function (data, status, xhr) {
////    //          //  console.log(r);

////    //            var obj = {};
////    //            obj.data = [];
////    //            obj.data.push({ ProductID: r.ProductID, Name: name });

////    //            var source = $("#listtemplate").html();
////    //            var template = Handlebars.compile(source);

////    //            var html = template(obj);

////    //            //if (id > 0) {
////    //            //    $("#tblBody tr[pid=" + id + "]").replaceWith(html);
////    //            //}
////    //            //else {
////    //            //    $("#tblBody").prepend(html);
////    //            //}

////    //            //BindEvents();

////    //            //Clear();

////    //            alert("record is saved");
////    //        },
////    //        error: function () {
////    //            alert('error has occured');
////    //        }
////    //    };

//////    //    $.ajax(settings);
//////    //}
//////function BindEvents() {

//////    $(".editprod").unbind("click").bind("click", function () {
//////        var $tr = $(this).closest("tr");
//////        var pid = $tr.attr("pid");

//////        var d = { "pid": pid };

//////        MyAppGlobal.MakeAjaxCall("GET", 'Product2/GetProductById', d, function (resp) {
//////            $("#txtProductID").val(resp.data.ProductID);
//////            $("#txtPictureName").val(resp.data.PictureName);
//////            $("#txtName").val(resp.data.Name);
//////            $("#txtPrice").val(resp.data.Price);
//////            $("#prodimg").show().attr("src", window.BasePath + "UploadedFiles/" + resp.data.PictureName);

//////        });

//////        return false;
//////    });

//////    $(".deleteprod").unbind("click").bind("click", function () {

//////        if (!confirm("Do you want to continue?")) {
//////            return;
//////        }
//////        var $tr = $(this).closest("tr");
//////        var pid = $tr.attr("pid");

//////        var d = { "pid": pid };

//////        MyAppGlobal.MakeAjaxCall("POST", 'Product2/DeleteProduct', d, function (resp) {

//////            $tr.remove();
//////        });


//////        return false;
//////    });

//////    $(".emailprod").unbind("click").bind("click", function () {
//////        var $tr = $(this).closest("tr");
//////        var pid = $tr.attr("pid");

//////        var d = { "pid": pid };

//////        MyAppGlobal.MakeAjaxCall("GET", 'Product2/GetProductById', d, function (resp) {

//////            $("#popupname").text(resp.data.Name);

//////            $("#overlay").show();

//////            $("#emailpopup").show();

//////        });

//////        return false;
//////    });
//////}

////return {
////    Main: function () {
////        $("#btnSave1").click(function () {

////            SaveProduct();
////            return false;
////        });
////    }
////};

////})();

var MyApp = {};

MyApp = (function () {

    function SaveProduct() {

        var data = new FormData();

        var email = $("#email").val();
        var name = $("#name1").val();
        var Designation = $("#Designation").val();
        var password = $("#password1").val();
        var cn_password = $("#cn_password").val();
        var oldPicName = $("#txtPictureName").val();

        data.append("name", name);
        data.append("email", email);
        data.append("Designation", Designation);
        data.append("password1", password);
        data.append("cn_password", cn_password);
        data.append("PictureName", oldPicName);


        var files = $("#myfile").get(0).files;
        if (files.length > 0) {
            data.append("Image", files[0]);
        }

        var settings = {
            type: "POST",
            url: 'SaveUsers',
            contentType: false,
            processData: false,
            data: data,
            success: function (data, status, xhr) {
            //    if (success==true) {
                    alert("record is saved successfully !!! ");
                    location.href = "/Home/Login"
                //}
                //else {

                    //alert("invalid data entered !!! ");
                    //location.href = "/Home/Login"
            //    }
            },
            error: function () {
                alert('error has occured');
            }
        };

        $.ajax(settings);
    }
    function BindEvents() {

        $(".editprod").unbind("click").bind("click", function () {
            var $tr = $(this).closest("tr");
            var pid = $tr.attr("pid");

            var d = { "pid": pid };

            MyAppGlobal.MakeAjaxCall("GET", 'Product2/GetProductById', d, function (resp) {
                $("#txtProductID").val(resp.data.ProductID);
                $("#txtPictureName").val(resp.data.PictureName);
                $("#txtName").val(resp.data.Name);
                $("#txtPrice").val(resp.data.Price);
                $("#prodimg").show().attr("src", window.BasePath + "UploadedFiles/" + resp.data.PictureName);

            });

            return false;
        });

        $(".deleteprod").unbind("click").bind("click", function () {

            if (!confirm("Do you want to continue?")) {
                return;
            }
            var $tr = $(this).closest("tr");
            var pid = $tr.attr("pid");

            var d = { "pid": pid };

            MyAppGlobal.MakeAjaxCall("POST", 'Product2/DeleteProduct', d, function (resp) {

                $tr.remove();
            });


            return false;
        });

        $(".emailprod").unbind("click").bind("click", function () {
            var $tr = $(this).closest("tr");
            var pid = $tr.attr("pid");

            var d = { "pid": pid };

            MyAppGlobal.MakeAjaxCall("GET", 'Product2/GetProductById', d, function (resp) {

                $("#popupname").text(resp.data.Name);

                $("#overlay").show();

                $("#emailpopup").show();

            });

            return false;
        });
    }

    return {
        Main: function () {
            $("#btnSave1").click(function () {

                SaveProduct();
                return false;
            });
        }
    };

})();

