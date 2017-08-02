
$(document).ready(function () {
    $("#preview").fadeOut(15);
    $("#refreshButton").click(function () {
        var imageToLoad = $("#imageId").val();
        if (imageToLoad.length > 0) {
            $("#preview").attr("src", "/Document/Show/" + imageToLoad);
            $("#preview").fadeIn();
        }
    });
});