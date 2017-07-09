var MyApp = {};
//GetProductForSell()GetProductByUserId(int id)
MyApp = (function () {


    function Clear() {
        $("#txtProductID").val(0);
        $("#txtPictureName").val("");
        $("#txtName").val("");
        $("#txtPrice").val("");
        $("#prodimg").hide();
    }
    function SaveProduct() {

        var data = new FormData();

        var id = $("#txtProductID").val();
        var name = $("#txtName").val();
        var price = $("#txtPrice").val();
        var oldPicName = $("#txtPictureName").val();

        data.append("ProductID", id);
        data.append("Name", name);
        data.append("Price", price);
        data.append("PictureName", oldPicName);


        var files = $("#myfile").get(0).files;
        if (files.length > 0) {
            data.append("Image", files[0]);
        }

        var settings = {
            type: "POST",
            url: window.BasePath + 'Product2/Save',
            contentType: false,
            processData: false,
            data: data,
            success: function (r) {
                console.log(r);

                var obj = {};
                obj.data = [];
                obj.data.push({ ProductID: r.ProductID, Name: name, Price: price, PictureName: r.PictureName });

                var source = $("#listtemplate").html();
                var template = Handlebars.compile(source);

                var html = template(obj);

                if (id > 0) {
                    $("#tblBody tr[pid=" + id + "]").replaceWith(html);
                }
                else {
                    $("#tblBody").prepend(html);
                }

                BindEvents();

                Clear();

                alert("record is saved");
            },
            error: function () {
                alert('error has occurred');
            }
        };

        $.ajax(settings);
    }



function LoadProductsById() {


    MyAppGlobal.MakeAjaxCall("GET", 'Product2/GetProductById', {}, function (resp) {

        if (resp.data) {
            debugger;
            for (var k in resp.data) {
                var obj = resp.data[k];
                obj.CreatedOn = moment(obj.CreatedOn).format('DD/MM/YYYY HH:mm:ss');

                for (var k2 in obj.Comments) {
                    var comm = obj.Comments[k2];
                    comm.CommentOn = moment(comm.CommentOn).format('DD/MM/YYYY HH:mm:ss');
                }
            }


            var source = $("#listtemplate").html();
            var template = Handlebars.compile(source);

            var html = template(resp);
            $("#tblBody").append(html);


            BindEvents1();
        }
    });

}
function BindEvents1() {

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
}


    

return {
    Main: function (pid) {

        LoadProducts();

        $("#btnSave").click(function () {

            SaveProduct();
            return false;
        });

        $("#btnClear").click(function () {

            Clear();
            return false;
        });

        $("#btnSend").click(function () {
            //Call send email function
            $("#emailpopup").hide();
            $("#overlay").hide();
            return false;
        });
        $("#btnClose").click(function () {
            $("#emailpopup").hide();
            $("#overlay").hide();
            return false;
        });
    }
};

})();




