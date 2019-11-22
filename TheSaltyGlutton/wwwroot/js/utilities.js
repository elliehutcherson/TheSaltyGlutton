$(function () {
    function launch() {
        $('.ut-collapse-horizontal').addClass('ut-hide');
    }

    $('[data-toggle="ut-collapse-horizontal"]').on('click', function () {

        let id = $(this).attr('data-toggle');
        $('#' + id).toggleClass('ut-hide');

    });
});