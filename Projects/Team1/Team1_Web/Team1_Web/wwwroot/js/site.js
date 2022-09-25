$(function () {
    $('#action_vs').click(function () {
        var url = $(this).data('request-url');
        val1 = "5";
        val2 = "2";
        return $.ajax({
            type: "POST",
            url: url,
            data: { number1: val1, number2: val2 },
            dataType: "text",
            success: function (msg) {
                alert(msg);
            },
            error: function (req, status, error) {
                alert(error);
            }
        });
    });
});