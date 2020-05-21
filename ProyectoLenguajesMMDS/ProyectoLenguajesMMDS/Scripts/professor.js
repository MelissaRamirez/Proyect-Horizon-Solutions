$(document).ready(function () {
    FillProvinceDropdown();
    GetCanton();
    GetDistrict();
});



function Add() {

    var person = {
        Person_id: $('#PersonId').val(),
        Email: $('#Email').val(),
        Password: $('#Password').val(),
        Name: $('#Name').val(),
        Last_name: $('#LastName').val(),
        Interests: $('#Interests').val(),
        Profile_pic: $('#ProfilePic').val(),
        Status: $('#Status').val(),
        Distric_id: $('#DistrictId').val(),
        Canton_id: $('#CantonId').val(),
        Province_id: $('ProvinceId').val()
    }

    var professor = {
        Professor_id: $('#ProfessorId').val(),
        Especiality: $('#Especiality').val(),
        Is_admin: $('#isAdmin').val(),
        Person: person
    }

    $.ajax({
        url: "/Professor/Register",
        data: JSON.stringify(professor),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            toastr.success("Information sent", "Success!");

        },
        error: function (errorMessage) {

        }
    });
}

function FillProvinceDropdown() {

    $.ajax({
        type: "GET",
        url: "/Person/GetProvince",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            var s = '<option value="-1">Seleccione la Provincia</option>';
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].Province_id + '">' + data[i].Name + '</option>';
            }
            $("#provinceDropdown").html(s);
        }
    });
}


function GetCanton() {

    $(document).on("change", ".province", function () {

        var idProvince = $("#provinceDropdown").val()

        $.ajax({
            url: "/Person/GetCanton/"+ idProvince,
            type: "GET",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (data) {
                var s = '<option value="-1">Seleccione el Cantón</option>';
                for (var i = 0; i < data.length; i++) {
                    s += '<option value="' + data[i].Canton_id + '">' + data[i].Name + '</option>';
                }
                $("#cantonDropdown").html(s);
            }
        });

    });


}

function GetDistrict() {

    $(document).on("change", ".canton", function () {

        var canton = {
            Province_id: $("#provinceDropdown").val(),
            Canton_id: $("#cantonDropdown").val()
        }

        $.ajax({
            url: "/Person/GetDistric/",
            data: JSON.stringify(canton),
            type: "GET",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (data) {
                var s = '<option value="-1">Seleccione el Distrito </option>';
                for (var i = 0; i < data.length; i++) {
                    s += '<option value="' + data[i].Distric_id + '">' + data[i].Name + '</option>';
                }
                $("#provinceDropdown").html(s);
            }
        });

    });

}








