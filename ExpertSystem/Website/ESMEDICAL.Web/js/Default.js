var pageIndex = 1;
$(document).ajaxStart($.blockUI).ajaxStop($.unblockUI);
$(document).ready(function () {
    $(".btn-primary").on("click", function () {
        Search();
    });
    $(".btn-default").on("click", function () {
        Clear();
    });
    $('.number').autoNumeric('init', { mDec: '0', vMax: 100 });
});

function Search() {
    result_hide();

    var txtName = $('#txtName'); var txtAge = $('#txtAge'); var cboGender = $('#cboGender'); 

    txtName.on('change keyup paste', function () { txtName.parent().removeClass("has-error"); });
    txtAge.on('change keyup paste', function () { txtAge.parent().removeClass("has-error"); });
    cboGender.on('change keyup paste', function () { cboGender.parent().removeClass("has-error"); });

    var checkData = true;
    if (getString(txtName).length == 0) {
        txtName.parent().addClass("has-error");
        checkData = false;
    }
    if (getString(txtAge).length == 0 || getNumeric(txtAge) == 0) {
        txtAge.parent().addClass("has-error");
        checkData = false;
    }
    if (getString(cboGender).length == 0 || getString(cboGender) == 'None') {
        cboGender.parent().addClass("has-error");
        checkData = false;
    }

    if (checkData == false) return;

    var Name = getString(txtName);
    var Age = getString(txtAge);
    var Gender = getString(cboGender);
    var Polyuria = $("#rblPolyuria input[type='radio']:checked").val();
    var Polydipsia = $("#rblPolydipsia input[type='radio']:checked").val();
    var SuddenWeightLoss = $("#rblSuddenWeightLoss input[type='radio']:checked").val();
    var Weakness = $("#rblWeakness input[type='radio']:checked").val();
    var Polyphagia = $("#rblPolyphagia input[type='radio']:checked").val();
    var GenitalThrush = $("#rblGenitalThrush input[type='radio']:checked").val();
    var VisualBlurring = $("#rblVisualBlurring input[type='radio']:checked").val();
    var Itching = $("#rblItching input:checked").val();
    var Irritability = $("#rblIrritability input[type='radio']:checked").val();
    var DelayedHealing = $("#rblDelayedHealing input[type='radio']:checked").val();
    var PartialParesis = $("#rblPartialParesis input[type='radio']:checked").val();
    var MuscleStiffness = $("#rblMuscleStiffness input[type='radio']:checked").val();
    var Alopecia = $("#rblAlopecia input[type='radio']:checked").val();
    var Obesity = $("#rblObesity input[type='radio']:checked").val();

    $.ajax({
        type: "POST",
        url: "/Default.aspx/Search",
        data: JSON.stringify({ Name: Name, Age: Age, Gender: Gender, Polyuria: Polyuria, Polydipsia: Polydipsia, SuddenWeightLoss: SuddenWeightLoss, Weakness: Weakness, Polyphagia: Polyphagia, GenitalThrush: GenitalThrush, VisualBlurring: VisualBlurring, Itching: Itching, Irritability: Irritability, DelayedHealing: DelayedHealing, PartialParesis: PartialParesis, MuscleStiffness: MuscleStiffness, Alopecia: Alopecia, Obesity: Obesity }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.d.substring(0, 3) === 'Loi') {
                result_show(response.d.substring(3));
            }
            else {
                result_show(response.d);
            }
            $(window).scrollTop(0);
        },
        error: ajax_error
    });
}

function Clear() {
    result_hide();

    var txtName = $('#txtName'); var txtAge = $('#txtAge'); var cboGender = $('#cboGender');

    txtName.parent().removeClass("has-error");
    txtAge.parent().removeClass("has-error");
    cboGender.parent().removeClass("has-error");

    txtName.val('');
    txtAge.val('');
    cboGender.val('');

    $("[id$=rblPolyuria]").find("input[value='No']").prop("checked", true);
    $("[id$=rblPolydipsia]").find("input[value='No']").prop("checked", true);
    $("[id$=rblSuddenWeightLoss]").find("input[value='No']").prop("checked", true);
    $("[id$=rblWeakness]").find("input[value='No']").prop("checked", true);
    $("[id$=rblPolyphagia]").find("input[value='No']").prop("checked", true);
    $("[id$=rblGenitalThrush]").find("input[value='No']").prop("checked", true);
    $("[id$=rblVisualBlurring]").find("input[value='No']").prop("checked", true);
    $("[id$=rblItching]").find("input[value='No']").prop("checked", true);
    $("[id$=rblIrritability]").find("input[value='No']").prop("checked", true);
    $("[id$=rblDelayedHealing]").find("input[value='No']").prop("checked", true);
    $("[id$=rblDelayedHealing]").find("input[value='No']").prop("checked", true);
    $("[id$=rblPartialParesis]").find("input[value='No']").prop("checked", true);
    $("[id$=rblMuscleStiffness]").find("input[value='No']").prop("checked", true);
    $("[id$=rblAlopecia]").find("input[value='No']").prop("checked", true);
    $("[id$=rblObesity]").find("input[value='No']").prop("checked", true);
    $("[id$=rblClass]").find("input[value='Negative']").prop("checked", true);

    $(window).scrollTop(0);
}

function result_hide() {
    if ($('.result').hasClass('show')) {
        $('.result').removeClass("show");
        $('.result').addClass("hide");
        $('.result').html('');
    }
}
function result_show(value) {
    if ($('.result').hasClass('hide')) {
        $('.result').removeClass("hide");
        $('.result').addClass("show");
        $('.result').html(value);
    }
}
