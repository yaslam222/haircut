$(document).ready(function () {

    // Handle Edit Button Click
    $(document).on('click', '.btnEdit', function () {
        var id = $(this).data('id');
        var title = $(this).data('title');
        var description = $(this).data('description');
        var imagepath = $(this).data('imagepath');

        // Populate modal with current data
        $('#editBeautyCardId').val(id);
        $('#edittitle').val(title);
        $('#editdescription').val(description);
        $('#editimagepath').val(imagepath);
    });

    // Handle Submit for Edit
    $('#btnEditBeautyCard').on('click', function () {
        var isValid = true;

        // Validate form inputs
        $('#BeautyCardInfoEdit input[required]').each(function () {
            if ($(this).val().trim() === '') {
                isValid = false;
                $(this).addClass('is-invalid');
                $(this).next('.invalid-feedback').show();
            } else {
                $(this).removeClass('is-invalid');
                $(this).next('.invalid-feedback').hide();
            }
        });

        if (!isValid) {
            toastr.error('Please fill out all required fields.');
            return;
        }

        var formData = $('#BeautyCardInfoEdit').serialize(); // Serialize form data

        // Disable submit button to prevent multiple submissions
        $(this).prop('disabled', true);

        $.ajax({
            type: 'POST',
            url: '/Admin/BeautyCardInfo/Edit',
            data: formData,
            success: function (response) {
                if (response.success) {
                    toastr.success('Beauty Card information updated successfully');
                    location.reload();  // Reload the page after success
                } else {
                    toastr.error('Error updating the Beauty Card');
                }
            },
            error: function () {
                toastr.error('An error occurred while updating');
            },
            complete: function () {
                $('#btnEditBeautyCard').prop('disabled', false); // Re-enable button
            }
        });
    });

    // Handle Submit for Create
    $('#btnSubmitCardInfo').on('click', function () {
        var isValid = true;

        // Validate form inputs
        $('#CardInfoAdd input[required]').each(function () {
            if ($(this).val().trim() === '') {
                isValid = false;
                $(this).addClass('is-invalid');
                $(this).next('.invalid-feedback').show();
            } else {
                $(this).removeClass('is-invalid');
                $(this).next('.invalid-feedback').hide();
            }
        });

        if (!isValid) {
            toastr.error('Please fill out all required fields.');
            return;
        }

        var formData = $('#CardInfoAdd').serialize(); // Serialize form data

        // Disable submit button to prevent multiple submissions
        $(this).prop('disabled', true);

        $.ajax({
            type: 'POST',
            url: '/Admin/BeautyCardInfo/Create',
            data: formData,
            success: function (response) {
                if (response.success) {
                    toastr.success('Beauty Card information added successfully');
                    location.reload();  // Reload the page after success
                } else {
                    toastr.error('Error adding the Beauty Card');
                }
            },
            error: function () {
                toastr.error('An error occurred while adding');
            },
            complete: function () {
                $('#btnSubmitCardInfo').prop('disabled', false); // Re-enable button
            }
        });
    });

    // Handle Delete Button Click
    $(document).on('click', '.DeleteBeautyCardInfo', function () {
        var id = $(this).data('id');

        Swal.fire({
            title: 'Are you sure?',
            text: "This action cannot be undone!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: 'POST',
                    url: '/Admin/BeautyCardInfo/Delete',
                    data: { id: id },
                    success: function (response) {
                        if (response.success) {
                            toastr.success('Beauty Card deleted successfully');
                            location.reload();
                        } else {
                            toastr.error('Error deleting the Beauty Card');
                        }
                    },
                    error: function () {
                        toastr.error('An error occurred while deleting');
                    }
                });
            }
        });
    });
});
