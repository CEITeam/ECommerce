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

    global.registerCustomer = registerCustomer;
    global.registerBrand = registerBrand;
}(this, document));