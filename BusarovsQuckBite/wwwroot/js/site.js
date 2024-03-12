// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.
function HideErrorMessage() {
    var successAlerts = document.querySelectorAll('.errorMessageToHide');
    if (successAlerts) {
        successAlerts.forEach(function (successAlert) {
            $(successAlert).fadeOut(500, function () {
                $(this).remove();
            });
        });
    }
}
setInterval(HideErrorMessage, 3000);
function HideSuccessMessage() {
    var successAlerts = document.querySelectorAll('.successMessageToHide');
    if (successAlerts) {
        successAlerts.forEach(function (successAlert) {
            $(successAlert).fadeOut(500, function () {
                $(this).remove();
            });
        });
    }
}
setInterval(HideSuccessMessage, 3000);