function attachEvents() {
    $('#fbButton').on('click', function (e) {
        e.preventDefault()
        swal({
            title: "Leave this site?",
            text: "If you click 'OK', you will be redirected to https://facebook.com!",
            type: "warning",
            showCancelButton: true,
            confirmButtonClass: "btn-primary",
            confirmButtonText: "OK",
            closeOnConfirm: false
        }, function () {
            window.location.replace("https://facebook.com");
        });
    })

    $('#ggButton').on('click', function (e) {
        e.preventDefault()
        swal({
            title: "Leave this site?",
            text: "If you click 'OK', you will be redirected to https://google.com!",
            type: "warning",
            showCancelButton: true,
            confirmButtonClass: "btn-primary",
            confirmButtonText: "OK",
            closeOnConfirm: false
        }, function () {
            window.location.replace("https://google.com");
        });
    })

    $('#submitButton').on('click', function (e) {
        e.preventDefault()
        $('#form')[0].reset()
        $('.dropify-clear').click();
        swal("Good job!", "You are registered!", "success")
    })
}