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