// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your Javascript code.
//var filterValue;
ready(allfunctions);
function ready(fn) {
    if (document.readyState != 'loading') {
        fn();
    } else {
        document.addEventListener('DOMContentLoaded', fn);
    }
}

function allfunctions() {
    //SetDocumentPosition();

    document.getElementById("button-up").addEventListener("click", moveUp);

    //document.getElementById("formFilter").onsubmit(function (e) {
    //    e.preventDefault();
    //    var form = this;
    //    filterValue = document.getElementById("filterInput").innerHTML;
    //    var url = form.attr('action');
    //    fetch(url, {
    //        method: "GET",
    //        data: form.serialize(),
    //        success: formCallback
    //    })
    //});

    //document.querySelector("a.order").addEventListener("Click", e => function (e) {
    //    e.preventDefault();
    //    var element = ocument.querySelector("a.order");
    //    var url = element.attr('href');
    //    fetch(url, {
    //        method: "GET",
    //        success:formCallback
    //    })
    //});

    //$(window).scroll(function (event) {
    //    Cookies.set("position", $(window).scrollTop());
    //})

};

//function formCallback(event) {
//    //$("#mainTable").html($(event).find("#mainTable").html());
//    document.querySelector("#mainTable").innerHTML(event.querySelector("#mainTable").innerHTML());
//}

//function SetDocumentPosition() {
//    var postion = Cookies.get("position");
//    //$(window).scrollTop(postion);
//    window.scrollBy(0, position);
}

function moveUp() {
    //while (window.pageYOffset >= 10) {
    //    var position = window.pageYOffset;
    //    window.pageYOffset = position - 10;
    //}
    alert("dupa");
}

//function sleep(ms) {
//    return new Promise(resolve => setTimeout(resolve, ms));
//}