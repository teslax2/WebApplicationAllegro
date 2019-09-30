// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var filterValue;

$(document).ready(function () {
    $("#formFilter").submit(function (e) {
        e.preventDefault();
        var form = $(this);
        filterValue = $("#filterInput").val();
        var url = form.attr('action');
        $.ajax({
            type: "GET",
            url: url,
            data: form.serialize(),
            success: formCallback
        })
    });
    $("a.order").click(function (e) {
        e.preventDefault();
        var element = $(this);
        var url = element.attr('href') + "&filter=" + filterValue;
        $.ajax({
            type: "GET",
            url: url,
            success: formCallback
        })
    });
})

function formCallback(event) {
    $("#mainTable").html($(event).find("#mainTable").html());
} 