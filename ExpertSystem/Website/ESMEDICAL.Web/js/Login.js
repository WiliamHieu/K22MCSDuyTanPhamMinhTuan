$(document).ajaxStart($.blockUI).ajaxStop($.unblockUI);
$(document).ready(function () {
    $("#cmdLogin").click(function () {
        alert_hide();

        var txtUsername = $('#txtUsername'); var txtPassword = $('#txtPassword');
        txtUsername.on('change keyup paste', function () { txtUsername.parent().removeClass("has-error"); });
        txtPassword.on('change keyup paste', function () { txtPassword.parent().removeClass("has-error"); });

        var Username = getString(txtUsername);
        var Password = getString(txtPassword);

        var validData = true;
        if (Username.length === 0) {
            txtUsername.parent().addClass("has-error");
            validData = false;
        }
        if (Password.length === 0) {
            txtPassword.parent().addClass("has-error");
            validData = false;
        }
        if (!validData) return;

        $.ajax({
            type: "POST",
            url: "/Login.aspx/DoLogin",
            data: JSON.stringify({ Username: Username, Password: Password }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                if (response.d.length > 0) {
                    alert_show(response.d);
                }
                else {
                    $(location).attr("href", '/diabetes');
                }
            },
            error: ajax_error
        });
        return false;
    });
});
