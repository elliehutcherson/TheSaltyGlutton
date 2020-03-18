// create.js, javascript to run on the create view for Equipment Controller

$(function () {

    // defined below
    StatesByCountry();
        
    function StatesByCountry() {
        // get url from the hidden input element
        let urlEquipmentModelsByVendor = $('#VendorId').attr('data-url');

        $('#VendorId').on('change', function () {
            let id = $('#VendorId').val();
            let url = urlEquipmentModelsByVendor + '/' + id
            let options = {
                url: url,
                method: 'get',
            };

            $.ajax(options).done(function (data) {
                var $dropVersion = $('#EquipmentModelId');
                $dropVersion.empty();

                $(data).each(function (key, item) {
                    $('<option>').val(item.Id).text(item.Name).appendTo($dropVersion);
                });
            });
        });
    }
});