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

const axios = require('axios')
const getBreeds = async () => {
    try {
        return await axios.get('https://dog.ceo/api/breeds/list/all')
    }
    catch (error)
    {
        console.error(error)
    }
}
const countBreeds = async () => {
    const breeds = await getBreeds()
    if (breeds.data.message)
    {
        console.log(`Got ${Object.entries(breeds.data.message).length} breeds`)
    }
}
countBreeds();

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
    if (getString(cboGender).length == 0 || getString(cboGender) == -1) {
        cboGender.parent().addClass("has-error");
        checkData = false;
    }

    if (checkData == false) return;

    var Name = getString(txtName);
    var Age = getString(txtAge);
    var Gender = getString(cboGender);
    var Polyuria = $("input[name='Polyuria']:checked").val();
    var Polydipsia = $("input[name='Polydipsia']:checked").val();
    var SuddenWeightLoss = $("input[name='SuddenWeightLoss']:checked").val();
    var Weakness = $("input[name='Weakness']:checked").val();
    var Polyphagia = $("input[name='Polyphagia']:checked").val();
    var GenitalThrush = $("input[name='GenitalThrush']:checked").val();
    var VisualBlurring = $("input[name='VisualBlurring']:checked").val();
    var Itching = $("input[name='Itching']:checked").val();
    var Irritability = $("input[name='Irritability']:checked").val();
    var DelayedHealing = $("input[name='DelayedHealing']:checked").val();
    var PartialParesis = $("input[name='PartialParesis']:checked").val();
    var MuscleStiffness = $("input[name='MuscleStiffness']:checked").val();
    var Alopecia = $("input[name='Alopecia']:checked").val();
    var Obesity = $("input[name='Obesity']:checked").val();

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
    txtAge.val(0);
    cboGender.val(-1);

    $("input[name='Polyuria'][value='0']").prop("checked", true);
    $("input[name='Polydipsia'][value='0']").prop("checked", true);
    $("input[name='SuddenWeightLoss'][value='0']").prop("checked", true);
    $("input[name='Weakness'][value='0']").prop("checked", true);
    $("input[name='Polyphagia'][value='0']").prop("checked", true);
    $("input[name='GenitalThrush'][value='0']").prop("checked", true);
    $("input[name='VisualBlurring'][value='0']").prop("checked", true);
    $("input[name='Itching'][value='0']").prop("checked", true);
    $("input[name='Irritability'][value='0']").prop("checked", true);
    $("input[name='DelayedHealing'][value='0']").prop("checked", true);
    $("input[name='PartialParesis'][value='0']").prop("checked", true);
    $("input[name='MuscleStiffness'][value='0']").prop("checked", true);
    $("input[name='Alopecia'][value='0']").prop("checked", true);
    $("input[name='Obesity'][value='0']").prop("checked", true);

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
