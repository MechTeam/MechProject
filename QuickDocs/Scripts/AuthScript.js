
$(document).ready(function () {
    var INPUT = $(".txt");   

    INPUT.keyup(function () {
        var CURRENT_INPUT = $(this);
        var LABEL_SELECTOR = "label[for='" + CURRENT_INPUT.attr("id") + "']";
        var TEXT = CURRENT_INPUT.val();

        $.ajax({
            type: 'POST',
            url: '/Auth/LoginValidation',
            data: { input: TEXT },
            success: function (data) {
                if (data.result == "OK") {
                    CURRENT_INPUT.css({ "border-color": "#00FF00" });
                }
                else {
                    CURRENT_INPUT.css({ "border-color": "#FF0000" });
                }

                $(LABEL_SELECTOR).text(data.result);
            },
            error: function (obj, error) {
                $(LABEL_SELECTOR).text("");
            }
        });
    });
});