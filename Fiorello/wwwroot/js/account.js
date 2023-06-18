$(document).ready(function () {
    $('#checkeye1').click(function () {
        var previousType = $(this).prev().attr("type");

        if (previousType === "password") {
            $(this).prev().removeAttr("type").attr("type", "text");
        } else {
            $(this).prev().removeAttr("type").attr("type", "password");
        }
    });

    $('#checkeye2').click(function () {
        var previousType = $(this).prev().attr("type");

        if (previousType === "password") {
            $(this).prev().removeAttr("type").attr("type", "text");
        } else {
            $(this).prev().removeAttr("type").attr("type", "password");
        }
    });

    $('#checkeye').click(function () {
        var previousType = $(this).prev().attr("type");

        if (previousType === "password") {
            $(this).prev().removeAttr("type").attr("type", "text");
        } else {
            $(this).prev().removeAttr("type").attr("type", "password");
        }
    });
});
