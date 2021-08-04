$(document).ajaxStart($.blockUI).ajaxStop($.unblockUI);
$(document).ready(function () {
    $(".mt-command :button").on("click", function () {
        var clickAction = $(this).data("action");
        if (clickAction === 2) {
            $(location).attr("href", $(this).data("url"));
            return;
        }
        DoSave();
    })
});

function DoSave() {
    alert_hide();
    var txtOldPassword = $('#txtOldPassword'); var txtNewPassword = $('#txtNewPassword');
    txtOldPassword.on('change keyup paste', function () {txtOldPassword.parent().removeClass("has-error");});
    txtNewPassword.on('change keyup paste', function () { txtNewPassword.parent().removeClass("has-error"); });

    var validData = true;
    var OldPassword = getString(txtOldPassword);
    if (OldPassword.length === 0) {
        txtOldPassword.parent().addClass("has-error");
        validData = false;
    }
    var NewPassword = getString(txtNewPassword);
    if (NewPassword.length === 0) {
        txtNewPassword.parent().addClass("has-error");
        validData = false;
    }
    if (!validData) return;

    $.ajax({
        type: "POST",
        url: "/UserInfo.aspx/DoSave",
        data: JSON.stringify({ OldPassword: OldPassword, NewPassword: NewPassword }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.d === 'ThanhCong') {
                $(location).attr("href", '/');
            }
            else {
               alert_show(response.d);
            }
        },
        error: ajax_error
    });
    return false;
}