$(document).ajaxStart($.blockUI).ajaxStop($.unblockUI);
$(document).ready(function () {
    $('#chkValidate').on('input change', function (e) {
        var Validate = $('#chkValidate').prop('checked');
        saveCookie("Validate", Validate);
    });
});

