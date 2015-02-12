
$(document).ready(function () {
    $('#loginTxt').on("keypress keydown",(function () {
        var text = $(this).val();
        $.ajax({
            type: 'POST',
            url: '/Auth/LoginValidation',
            data: { input: text },            
            success: function (data) {
                $('#loginMessage').text(data.result);
                if (data.result == "OK")
                    $("#loginTxt").css({ "border-color": "#00FF00", "background": "#00FF00" });
                else
                    $("#loginTxt").css({ "border-color": "#FF0000", "background": "#FF0000" });
            }
        });
    }));
});

$(document).ready(function () {
    $('#passwordTxt').on("keypress keydown",(function () {        
        var text = $(this).val();
        $.ajax({
            type: 'POST',
            url: '/Auth/PasswordValidation',
            data: { input: text },
            success: function (data) {                
                $('#passwordMessage').text(data.result);
                if (data.result == "OK")
                    $("#passwordTxt").css({ "border-color": "#00FF00", "background": "#00FF00" });
                else
                    $("#passwordTxt").css({ "border-color": "#FF0000", "background": "#FF0000" });
            }
        });

    }));
});


