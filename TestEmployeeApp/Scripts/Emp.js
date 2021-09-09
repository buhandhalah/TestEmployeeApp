var tableDetails = [];
var View_EmpServiceSubDocList = [];
var mode = "";
var appPath = window.location.protocol + "//" + window.location.host + "/";
$(document).ready(function () {


    if ($('#hd_mode').length) {
        mode = $('#hd_mode').val();
    }

});
// Uploading document
$(document).on('click', '.btn_attach_action_files', function () {
    if (!$("#file_txn").val()) {
        alert("Please select any file to upload!");
        return;
    }
    if (window.FormData !== undefined) {

        var FileName = "";
        var Description = "";
        var id = "0";
        if (mode == "edit") {
            id = $('#hd_id').val();
        }

        Description = $(".txt_pic_desc").val();
        var fileUpload = $("#file_txn").get(0);
        var files = fileUpload.files;
        var fileData = new FormData();
        var fileName = "";

        for (var i = 0; i < files.length; i++) {
            fileData.append(files[i].name, files[i]);
            fileName = files[i].name + ",";
        }
        FileName = fileName.trim(",");
        var tmppath = "";
        fileData.append('mode', $('#hd_mode').val());
        fileData.append('id', id);

        //var tmppath = URL.createObjectURL(event.target.files[0]);
        $.ajax({
            url: appPath + 'Home/uploadSupportFiles',
            type: "POST",
            contentType: false,
            processData: false,
            //enctype: 'multipart/form-data',
            //async: false,
            //cache: false, 
            data: fileData,
            success: function (data) {
                if (data.status) {
                    var html = "";
                    tmppath = appPath + data.uploadPath.substring(2);
                    for (var i = 0; i < data.FileName.length; i++) {
                        FileName = data.FileName[i];
                        OnlyFileName = data.OnlyFileName[i];

                        var orderItem = {
                            Description: Description,
                            FileName: FileName,
                            FilePath: data.FilePath
                        };
                        View_EmpServiceSubDocList.push(orderItem);

                        var tableItem = {
                            Description: Description,
                            FileName: FileName,
                            FilePath: data.FilePath,
                            OnlyFileName: OnlyFileName
                        };

                        tableDetails.push(tableItem);

                    }

                    if (mode == "edit") {
                        for (var m = 0; m < data.savedSubDoc.length; m++) {
                            html += "<tr><td><a href='" + tmppath + data.savedSubDoc[m].FilePath + data.savedSubDoc[m].FileName + "' target=\"_blank\" >" + data.savedSubDoc[m].FileName + "</a></td>";
                    
                            html += '<td> <button type="button" class ="btn go_back_btn" onclick="delEditSupportDoc(' + "'" + data.savedSubDoc[m].FileName + "'" + ',' + "'" + data.savedSubDoc[m].FilePath + "'" + ',' + id + ');" > Delete </button> </td ></tr>';
                        }
                        for (var k = 0; k < tableDetails.length; k++) {

                            html += "<tr><td><a href='" + tmppath + tableDetails[k].FilePath + tableDetails[k].FileName + "' target=\"_blank\" >" + tableDetails[k].FileName + "</a></td>";
                         
                            html += '<td> <button type="button" class ="btn go_back_btn" onclick="delEditSupportDoc(' + "'" + tableDetails[k].OnlyFileName + "'" + ',' + "'" + tableDetails[k].FilePath + "'" + ',' + id + ');" > Delete </button> </td ></tr>';

                        }
                    } else {
                        for (var k = 0; k < tableDetails.length; k++) {

                            html += "<tr><td><a href='" + tmppath + tableDetails[k].FilePath + tableDetails[k].FileName + "' target=\"_blank\">" + tableDetails[k].FileName + "</a></td>";
                      
                            html += '<td> <button type="button" class ="btn go_back_btn" onclick="delSupportDoc(' + "'" + tableDetails[k].OnlyFileName + "'" + ',' + "'" + tableDetails[k].FilePath + "'" + ');" > Delete </button> </td ></tr>';

                        }
                    }


                    $(".action_tbody").html('');
                    $(".action_tbody").append(html);

                    $(".div_attachs").show();
                    $('.txt_pic_desc').val('');
                    $('.file_txn').val('');
                    var msg_content = '<div class="alert alert-dismissible alert-success">' +
                        '<button type="button" class="close" data-dismiss="alert">&times;</button>' +
                        '<span>File has been added successfully!</span></div>';

                    $('.file_msg').html(msg_content).show();
                }
                else {
                    msg_content = '<div class="alert alert-dismissible alert-danger">' +
                        '<button type="button" class="close" data-dismiss="alert">&times;</button>' +
                        '<span>' + data.msg + '</span></div>';

                    $('.file_msg').html(msg_content).show();
                }

            },
            error: function (err) {
                var msg_content = '<div class="alert alert-dismissible alert-success">' +
                    '<button type="button" class="close" data-dismiss="alert">&times;</button>' +
                    '<span>' + err.statusText + '</span></div>';

                $('.file_msg').html(msg_content).show();

            }
        });
    } else {
        var msg_content = '<div class="alert alert-dismissible alert-success">' +
            '<button type="button" class="close" data-dismiss="alert">&times;</button>' +
            '<span>FormData is not supported.</span></div>';

        $('.file_msg').html(msg_content).show();

    }
});

function delEditSupportDoc(fileName, filePath, id) {
    $.ajax({
        type: "POST",
        url: appPath + 'Home/DeleteSupportDocEdit',
        data: { DelFileName: fileName, DelFilePath: filePath, ID: id },
        success: function (data) {
            if (data.status) {


                for (var i = 0; i < tableDetails.length; i++) {
                    if (tableDetails[i].OnlyFileName == fileName) {
                        tableDetails.splice(i, 1);
                        View_EmpServiceSubDocList.splice(i, 1);
                        break;
                    }
                }

                loadSubdocList(id);
            }
            else {
                msg_content = '<div class="alert alert-dismissible alert-danger">' +
                    '<button type="button" class="close" data-dismiss="alert">&times;</button>' +
                    '<span>' + data.msg + '</span></div>';

                $('.file_msg').html(msg_content).show();
            }
        },

        error: function (err) {
            var msg_content = '<div class="alert alert-dismissible alert-success">' +
                '<button type="button" class="close" data-dismiss="alert">&times;</button>' +
                '<span>' + err.statusText + '</span></div>';

            $('.file_msg').html(msg_content).show();

        }

    });
}

function delSupportDoc(fileName, filePath) {
    $.ajax({
        type: "POST",
        url: appPath + 'Home/DeleteSupportDoc',
        data: { DelFileName: fileName, DelFilePath: filePath },
        success: function (data) {
            var relativePath = data.relativePath.substring(2);
            if (data.status) {

                for (var i = 0; i < tableDetails.length; i++) {
                    if (tableDetails[i].OnlyFileName == fileName) {
                        tableDetails.splice(i, 1);
                        View_EmpServiceSubDocList.splice(i, 1);
                        break;
                    }
                }

                var html = "";
                var tmppath = "";
                for (var i = 0; i < tableDetails.length; i++) {
                    FileName = tableDetails[i].FileName;
                    html += "<tr><td><a href='" + appPath + relativePath + tableDetails[i].FilePath + FileName + "' target = \"_blank\">" + FileName + "</a></td>";
                   html += '<td> <button type="button" class ="btn go_back_btn" onclick="delSupportDoc(' + "'" + tableDetails[i].OnlyFileName + "'" + "," + "'" + tableDetails[i].FilePath + "'" + ');" > Delete </button> </td ></tr>';
                }
                $(".action_tbody").html('');
                $(".action_tbody").append(html);
                $('.txt_pic_desc').val('');
                $('.file_txn').val('');
                var msg_content = '<div class="alert alert-dismissible alert-success">' +
                    '<button type="button" class="close" data-dismiss="alert">&times;</button>' +
                    '<span>File has been removed successfully!</span></div>';

                $('.file_msg').html(msg_content).show();
            }
            else {
                msg_content = '<div class="alert alert-dismissible alert-danger">' +
                    '<button type="button" class="close" data-dismiss="alert">&times;</button>' +
                    '<span>' + data.msg + '</span></div>';

                $('.file_msg').html(msg_content).show();
            }
        },

        error: function (err) {
            var msg_content = '<div class="alert alert-dismissible alert-success">' +
                '<button type="button" class="close" data-dismiss="alert">&times;</button>' +
                '<span>' + err.statusText + '</span></div>';

            $('.file_msg').html(msg_content).show();

        }

    });
}

//Saving Details

$('.btn_save').click(function () {
    var isAllValid = true;
    var OrderAllDetails = [];
    var DocTypeHeader = [];
    var smode = "";

    var ItemID = "";
    var Description = "";
    var ItemTitle = "";

    smode = $(this).attr('data-smode');
    $('.div_msg').html('').hide();


    
    if ($('#EmpID').val() === "") {
        SetCustomValidationSelect2('#EmpID');
    }
    else {
        UnsetCustomValidationSelect2('#EmpID');
    }
   
    var EmpID = "";
   

        var DummyValue = "";

    if ($('#EmpID').val() != "") {
        EmpID = $('#EmpID').val().trim();
        }
       

        if (mode == "edit") {
       
        }
        else {
         
        }

      

    if (View_EmpServiceSubDocList.length >= 3) {

        Employee_Details = {
            EmpId: EmpID

        };

        Emp_Model = {
            Employee_Details: Employee_Details,
            DocumentsList: View_EmpServiceSubDocList
        };


        $.ajax({

            type: 'POST',
            url: appPath + 'Home/CreateDetails',
            data: JSON.stringify(Emp_Model),
            contentType: 'application/json',
            success: function (data) {
                if (data.status) {

                    View_EmpServiceSubDocList = [];
                    tableDetails = [];
                    window.location.href = appPath + 'Home/EmployeeDetails';
                }
                else {
                    alert("Warning! Something Went Wrong, Try Again");
                }
            }

        });
    }
    else {
        alert("Warning! Upload atleast 3 Documents to Proceed");
    }
});


function SetCustomValidationSelect2(elem) {
    $(elem).siblings('.select2-container--default').find('.select2-selection--single').addClass('parsley-error');
}
function UnsetCustomValidationSelect2(elem) {
    $(elem).siblings('.select2-container--default').find('.select2-selection--single').removeClass('parsley-error');
}