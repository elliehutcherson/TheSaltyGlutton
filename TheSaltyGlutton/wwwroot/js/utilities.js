$(function () {
    launch();

    function launch() {
        $('.ut-collapse-horizontal').addClass('ut-collapse-horizontal-hide');
    }

    $('[data-toggle="ut-collapse-horizontal"]').on('click', function () {
        let id = $(this).attr('data-target');

        console.log(id);

        $('#' + id).toggleClass('ut-collapse-horizontal-hide');
    });
});