function generalPdfFile(id) {
    $.ajax({
        url: "/Home/ExportPdf",
        data: {
            id: id
        },
        type: "POST",
        success: function (result) {
            debugger
        },
        error: function (err) {
            debugger
        }
    });
}