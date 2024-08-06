$(document).ready(function () {
    $('.js-delete').on('click', function () {
        var btn = $(this);

        const swal = Swal.mixin({
            customClass: {
                confirmButton: "btn btn-danger mx-2",
                cancelButton: "btn btn-light"
            },
            buttonsStyling: false
        });

        swal.fire({
            title: "Are you sure that you need to delete game?",
            text: "You won't be able to revert this!",
            icon: "warning",
            showCancelButton: true,
            confirmButtonText: "Yes, delete it!",
            cancelButtonText: "No, cancel!",
            reverseButtons: true
        }).then((result) => {
            console.log(result.isConfirmed);
            //if (result.isConfirmed) {
            //    swalWithBootstrapButtons.fire({
            //        title: "Deleted!",
            //        text: "Your file has been deleted.",
            //        icon: "success"
            //    });
            //} else if (
            //    /* Read more about handling dismissals below */
            //    result.dismiss === Swal.DismissReason.cancel
            //) {
            //    swalWithBootstrapButtons.fire({
            //        title: "Cancelled",
            //        text: "Your imaginary file is safe :)",
            //        icon: "error"
            //    });
            //}
        });

        //$.ajax({
        //    url: `/Games/Delete/${btn.data('id')}`,
        //    method: 'DELETE',
        //    success: function ()
        //    {
        //        alert('success');
        //    },
        //    error: function ()
        //    {
        //        alert('error');
        //    }
            
        //});
    });

});