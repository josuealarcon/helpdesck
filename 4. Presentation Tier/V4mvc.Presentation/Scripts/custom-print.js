$(document).ready(function () {
    $(document).on('click', '.custom-print-btn', function (e) {
        e.preventDefault();
        window.print();
    });
});