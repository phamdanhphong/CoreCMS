﻿var loginController = function () {
    this.initialize = function () {
        registerEvents();
    }
    var registerEvents = function () {
        $("#frmLogin").validate({
            errorClass: 'red',
            ignore: [],
            lang: 'vi',
            rules: {
                userName: {
                    required:true
                },
                Password: {
                    required: true
                }
            }


    });
        $("#btnLogin").on('click', function (e) {
            if ($('#frmLogin').valid()) {
                e.preventDefault();
                var user = $("#txtUserName").val();
                var password = $("#txtPassword").val();
                login(user, password);
            }
        });
    }
    var login = function (user, pass) {
        $.ajax({
            type: 'POST',
            data: {
                UserName: user,
                Password: pass
            },
            dataType: 'json',
            url: '/admin/login/authen',
            success: function(res) {
                if (res.Success) {
                    window.location.href = '/Admin/Home/Index';
                } else {
                    cms.notify('Đăng nhập không đúng', 'error');
                }

            }
        });
    }
}
$(document).ajaxSend(function (e, xhr, options) {
    if (options.type.toUpperCase() == "POST" || options.type.toUpperCase() == "PUT") {
        var token = $('form').find("input[name='__RequestVerificationToken']").val();
        xhr.setRequestHeader("RequestVerificationToken", token);
    }
});