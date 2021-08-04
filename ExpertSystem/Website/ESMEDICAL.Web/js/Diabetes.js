$(document).ajaxStart($.blockUI).ajaxStop($.unblockUI);
var PageIndex = 1;
$(document).ready(function () {
    $("#btnSearch").click(function () {
        Search();
    });

    $('.number').autoNumeric('init', { wEmpty: 'zero', mDec: '0', vMax: '100' });

    Paging_Init();
});

function Paging_Init() {
    var totalPages = getString($('#hTotalPages'));
    if (totalPages > 1) {
        $('#page-bottom').bootpag({
            total: totalPages,
            page: PageIndex,
            maxVisible: 5,
            leaps: true,
            firstLastUse: true,
            first: '←',
            last: '→',
            wrapClass: 'pagination',
            activeClass: 'active',
            disabledClass: 'disabled',
            nextClass: 'next',
            prevClass: 'prev',
            lastClass: 'last',
            firstClass: 'first'
        }).on("page", function (event, page) {
            PageIndex = page;
            var FromDate = getString($("#hFromDate"));
            var ToDate = getString($("#hToDate"));
            var Gender = getString($("#cboGender"));
            $.ajax({
                type: "POST",
                url: "/Diabetes.aspx/GetData",
                data: JSON.stringify({ FromDate: FromDate, ToDate: ToDate, Gender: Gender, PageIndex: PageIndex }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var result = response.d.split('!');
                    $("#dataHolder").html(result[0]);
                    $("#hTotalPages").val(result[1]);
                },
                error: ajax_error
            });
        });
    }
}

function Search() {
    alert_hide();

    var FromDate = getString($("#hFromDate"));
    var ToDate = getString($("#hToDate"));
    var Gender = getString($("#cboGender"));

    $.ajax({
        type: "POST",
        url: "/Diabetes.aspx/GetData",
        data: JSON.stringify({ FromDate: FromDate, ToDate: ToDate, Gender: Gender, PageIndex: PageIndex }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var result = response.d.split('|');
            $("#dataHolder").html(result[0]);
            $("#hTotalPages").val(result[1]);
            Paging_Init();
        },
        error: ajax_error
    });
}

function DeleteData(DiabetesId) {
    alert_hide();

    var FromDate = getString($("#hFromDate"));
    var ToDate = getString($("#hToDate"));
    var Gender = getString($("#cboGender"));

    PageIndex = 1;

    $.confirm({
        title: 'ESMedical',
        content: 'Bạn có chắc chắn xóa Thông tin này không?',
        confirm: function () {
            $.ajax({
                type: "POST",
                url: "/Diabetes.aspx/DeleteData",
                data: JSON.stringify({ DiabetesId: DiabetesId, FromDate: FromDate, ToDate: ToDate, Gender: Gender, PageIndex: PageIndex }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    if (response.d.substring(0, 3) === 'Loi') {
                        alert_show(response.d.substring(3));
                    }
                    else {
                        var result = response.d.split('!');
                        $("#dataHolder").html(result[0]);
                        $("#hTotalPages").val(result[1]);
                        Paging_Init();
                    }
                },
                error: ajax_error
            });
        }
    });
}

