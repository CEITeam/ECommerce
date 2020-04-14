// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
(function (global, doc) {

    let registerCustomer = () => {
        $("#registerBrand").addClass("d-none");
        $("#registerCustomer").removeClass("d-none");

    };

    let registerBrand = () => {
        $("#registerCustomer").addClass("d-none");
        $("#registerBrand").removeClass("d-none");
    };

    $("#dropDown").hover(
        function () {
            $(this).addClass("dropdown--opened");
        }, function () {
            $(this).removeClass("dropdown--opened");
        }
    );
    $(".radioBtn").click(function () {
        $("#discount").attr("disabled", true);
        if ($("input[name=status]:checked").val() == "0") {
            $("#discount").attr("disabled", false);
        }
    });
    global.registerCustomer = registerCustomer;
    global.registerBrand = registerBrand;
}(this, document));