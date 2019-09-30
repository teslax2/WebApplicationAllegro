// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    $("#formFilter").submit(function (e) {
        e.preventDefault(); // avoid to execute the actual submit of the form.
        var form = $(this);
        var url = form.attr('action');
        $.ajax({
            type: "GET",
            url: url,
            data: form.serialize(),
            success: formCallback
        })
    });
})

function formCallback(event) {
    $("#mainTable").html($(event).find("#mainTable").html());
} 
