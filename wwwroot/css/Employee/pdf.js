function generalPdfFile(id) {
    $.ajax({
        url: "/Home/ExportPdf",
        data: {
            id: id
        },
        type: "POST",
        success: function (result) {
            debugger
            downloadPdfFile(result);
        },
        error: function (err) {
            console.log(err);
        }
    });
}

function downloadPdfFile(data) {
    let bytes = convertToByte(data.byteArray);
    saveByteArray(bytes, data.fileName);
}

function convertToByte(data) {
    var binaryString = window.atob(data);
    var binaryLen = binaryString.length;
    let bytes = new Uint8Array(binaryLen);
    for (var i = 0; i < binaryLen; i++) {
        var ascii = binaryString.charCodeAt(i);
        bytes[i] = ascii;
    }

    return bytes;
}

function saveByteArray(bytes, fileName) {
    var blod = new Blob([bytes], { type: "application/pdf" });
    var link = document.createElement("a");
    link.href = window.URL.createObjectURL(blod);
    link.download = fileName;
    link.click();
}