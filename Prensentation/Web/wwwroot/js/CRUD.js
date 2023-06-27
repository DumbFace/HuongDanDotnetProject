function Create(url) {
    $.get(`${url}`, function (data) {
        $("#headerModal").html("Add");
        $("#loadModal").html(data);
        $.validator.unobtrusive.parse("#exampleModal");
    });
    myModal.show();
}

function Edit(url) {
    $.get(`${url}`, function (data) {
        $("#headerModal").html("Edit");
        $("#loadModal").html(data);
        $.validator.unobtrusive.parse("#exampleModal");
    });
}

function Delete() {

}

function LoadData(url) {
    $.get(`${url}`, function (data) {
        $("#example").html(data);
        $('#example').DataTable();
    });
}