$(document).ajaxStart($.blockUI).ajaxStop($.unblockUI);
$(document).ready(function () {
    $("#cmdLogin").click(function () {
        DoLogin();
    });
    $('#txtUsername').on('input change keyup copy paste cut', function (e) {
        BuidSQLQuery();
    });
    $('#txtPassword').on('input change keyup copy paste cut', function (e) {
        BuidSQLQuery();
    });
    $('#chkValidate').on('input change', function (e) {
        BuidSQLQuery();
    });
});

function BuidSQLQuery() {
    var Username = getString($('#txtUsername'));
    var Password = getString($('#txtPassword'));
    var Validate = $('#chkValidate').prop('checked');
    if (Validate) {
        Username = Username.replace(/[^a-z0-9\s]/gi, '');
        Password = Password.replace(/[^a-z0-9\s]/gi, '');
    }
    var sqlQuery = "SELECT Username, Password, Name, Status FROM Users WHERE Username='" + Username + "' AND Password='" + Password + "'";
    $('#txtSQLQuery').val(sqlQuery);
}

function DoLogin() {
    alert_hide();

    var txtUsername = $('#txtUsername'); var txtPassword = $('#txtPassword');
    txtUsername.on('change keyup paste', function () { txtUsername.parent().removeClass("has-error"); });
    txtPassword.on('change keyup paste', function () { txtPassword.parent().removeClass("has-error"); });

    var Username = getString(txtUsername);
    var Password = getString(txtPassword);
    var Remember = $('#chkRemember').prop('checked');

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

    var Validate = $('#chkValidate').prop('checked');
    if (Validate) {
        Username = Username.replace(/[^a-z0-9\s]/gi, '');
        Password = Password.replace(/[^a-z0-9\s]/gi, '');
    }

    $.ajax({
        type: "POST",
        url: "/Default.aspx/DoLogin",
        data: JSON.stringify({ Username: Username, Password: Password, Remember: Remember }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.d.length > 0) {
                alert_show(response.d);
            }
            else {
                $(location).attr("href", '/QueryString.aspx?Id=1');
            }
        },
        error: ajax_error
    });
    return false;
}
