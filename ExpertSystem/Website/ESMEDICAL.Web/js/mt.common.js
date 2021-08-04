function getStringClear(sContent) {
    sContent = sContent.trim();
    var rex = /(<([^>]+)>)/ig;
    var result = sContent.replace(rex, "");
    return result;
}
function getString(oString) {
    var result = '';
    if (oString.length > 0) {
        result = oString.val().trim();
        var rex = /(<([^>]+)>)/ig;
        result = result.replace(rex, "");
    }
    return result;
}
function getNumeric(objMonney) {
    if (objMonney.length > 0 && objMonney.val().length === 0) objMonney.val(0);
    var result = parseInt(objMonney.autoNumeric('get'));
    return result;
}
function saveCookie(cname, cvalue) {
    var d = new Date();
    d.setTime(d.getTime() + (1 * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + encodeURIComponent(cvalue) + "; " + expires + "; " + 'path=/';
}
function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1);
        if (c.indexOf(name) == 0) return decodeURIComponent(c.substring(name.length, c.length));
    }
    return "";
}
function deleteCookie(name) {
    saveCookie(name, "", -1);
}
function deleteCookieAll() {
    document.cookie.split(";").forEach(function (c) { document.cookie = c.replace(/^ +/, "").replace(/=.*/, "=;expires=" + new Date().toUTCString() + ";path=/"); });
}
function alert_hide() {
    if ($('.alert-danger').parent().hasClass('show')) {
        $('.alert-danger').parent().removeClass("show");
        $('.alert-danger').parent().addClass("hide");
        $('.alert-danger').html('');
    }
}
function alert_show(value) {
    if ($('.alert-danger').parent().hasClass('hide')) {
        $('.alert-danger').parent().removeClass("hide");
        $('.alert-danger').parent().addClass("show");
        $('.alert-danger').html(value);
    }
}
function ajax_error(xhr, errorType, exception) {
    var responseText; var errorMessage;
    try {
        responseText = jQuery.parseJSON(xhr.responseText);
        errorMessage = "<b>" + errorType + " " + exception + "</b>";
        errorMessage += "<br /><u>Exception</u>: " + responseText.ExceptionType;
        errorMessage += "<br /><u>StackTrace</u>: " + responseText.StackTrace;
        errorMessage += "<br /><u>Message</u>: " + responseText.Message;
    } catch (e) {
        errorMessage = xhr.responseText;
    }
    alert_show(errorMessage);
}
$(document).ready(function () {
    if ($('#btnFromDate').length) {
        $('#btnFromDate').datepicker({
            endDate: new Date,
            format: "dd/mm/yyyy",
            todayHighlight: true,
            autoclose: true,
            orientation: "right"
        }).on('changeDate', function () {
            var dateSelected = $('#btnFromDate').datepicker('getFormattedDate');
            $('#dvFromDateName').text(dateSelected);
            $('#hFromDate').val(dateSelected);
            saveCookie("FromDate", dateSelected);
            $('#btnFromDate').datepicker('hide');
        });
    }
    if ($('#btnToDate').length) {
        $('#btnToDate').datepicker({
            endDate: new Date,
            format: "dd/mm/yyyy",
            todayHighlight: true,
            autoclose: true,
            orientation: "right"
        }).on('changeDate', function () {
            var dateSelected = $('#btnToDate').datepicker('getFormattedDate');
            $('#dvToDateName').text(dateSelected);
            $('#hToDate').val(dateSelected);
            saveCookie("ToDate", dateSelected);
            $('#btnToDate').datepicker('hide');
        });
    }
});
