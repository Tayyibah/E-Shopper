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
            url: window.BasePath + '/Home/SaveUsers',
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
                $("#prodimg").show().attr("src", window.BasePath + "/UploadedFiles/" + resp.data.PictureName);

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

