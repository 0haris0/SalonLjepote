// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
jQuery(document).ready(function () {
    console.log('test0');
    $.urlParam = function (name) {
        var results = new RegExp('[\?&]' + name + '=([^&#]*)').exec(window.location.href);
        return results[1] || 1;
    }
    var vrstaID = $.urlParam('vrstaId');
    if (vrstaID > 0) {
        $('select').find('option[value="' + vrstaID + '"]').attr("selected", "selected")
    } 

})