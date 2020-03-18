
function DependantDropdown(parent, child, url) {
    $(parent).on('change', function () {
        let id = $(this).val();
        let urlSearch = url + '/' + id
        let options = {
            url: urlSearch,
            method: 'get',
        };

        $.ajax(options).done(function (data) {
            var $child = $(child);
            $child.empty();

            $(data).each(function (key, item) {
                $('<option>').val(item.Id).text(item.Name).appendTo($child);
            });
        });
    });
}