$(document).ready(function () {
    (screensize = function () {
        alert("Window:  " + window.innerWidth + " x " + window.innerHeight + "\n" +
                "Viewport:  " + document.documentElement.clientWidth + " x " + document.documentElement.clientHeight + "\n" +
                "Avl. Window: " + window.screen.availWidth + " x " + window.screen.availHeight);
    });

    $('#demoModal').on('shown.bs.modal', function () {


    });


    $('#showNewUser').click(function () {
        var url = $('#demoModal').data('url');

        $.get(url, function (data) {
            $('.modal-body').html(data);
            $.validator.unobtrusive.parse($("#demoModal form"));
            $('#demoModal').modal('show');
            $('.form-group > label').css('width: 20%');
        });
    });
});