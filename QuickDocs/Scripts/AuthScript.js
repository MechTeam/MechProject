
$(document).ready(function () {
    $('#loginTxt').keypress(function () {
        var text = $(this).val();
        $.ajax({
            type: 'POST',
            url: '/Auth/LoginValidation',
            data: { input: text },            
            success: function (data) {
                $('#loginMessage').text(data.result);                
            }
        });
    });
});

$(document).ready(function () {
    $('#passwordTxt').keypress(function () {        
        var text = $(this).val();
        $.ajax({
            type: 'POST',
            url: '/Auth/PasswordValidation',
            data: { input: text },
            success: function (data) {                
                $('#passwordMessage').text(data.result);
            }
        });

    });
});


