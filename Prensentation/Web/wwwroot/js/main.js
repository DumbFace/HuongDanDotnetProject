(function ($) {
    "use strict";
    var fullHeight = function () {
        $('.js-fullheight').css('height', $(window).height());
        $(window).resize(function () {
            $('.js-fullheight').css('height', $(window).height());
        });
    };
    fullHeight();
    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });



    // var editorConfig = {}
    // editorConfig.toolbar = "mytoolbar";
    // editorConfig.toolbar_mytoolbar = "{bold,italic,underline}|{fontname,fontsize}|{forecolor,backcolor}|removeformat"
    //     + "#{undo,redo,fullscreenenter,fullscreenexit,togglemore}";
    // var editor = new RichTextEditor("#editor", editorConfig);

}
)(jQuery);


// function InsertHTML(data) {
//     const viewFragment = editor.data.processor.toView(data);
//     const modelFragment = editor.data.toModel(viewFragment);
//     editor.model.insertContent(modelFragment);
// }


function Create(e) {
    var article = new Object();
    article.Title = $("#Title").val();
    article.Description = $("#Description").val();
    article.Content = editor.getHTMLCode();
    article.Thumb = $("#Thumb").val();
    article.Category = Number($("#Category").val());
    article.Status = Number($("#Status").val());
    $.ajax({
        type: "POST",
        url: "/cp/article/Create",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(article),
        success: function (result) {
            if (result == "Saved!")
                document.location = "/cp";
        }
    })
}
function convertTZ(date, tzString) {
    return new Date((typeof date === "string" ? new Date(date) : date).toLocaleString("en-US", { timeZone: tzString }));
}
convertTZ("2012/04/20 10:10:30 +0000", "Asia/Jakarta") // Tue Apr 20 2012 17:10:30 GMT+0700 (Western Indonesia Time)
// usage: Asia/Jakarta is GMT+7

// Resulting value is regular Date() object
const convertedDate = convertTZ("2012/04/20 10:10:30 +0000", "Asia/Jakarta")
convertedDate.getHours(); // 17

// Bonus: You can also put Date object to first arg
const date = new Date()
var test = convertTZ(date, "Asia/Jakarta") // current date-time in jakarta.
// alert(test)
function Update() {
    var article = new Object();
    article.Id = $("#Id").val();
    article.Url = $("#Url").val();

    // var test1 = new Date($("#DateCreate").val());
    // var test2 = new Date($("#DatePublish").val());
    // var test3 = new Date($("#DateModified").val());
    article.DateCreate = new Date($("#DateCreate").val());
    article.DatePublish = new Date($("#DatePublish").val());
    article.DateModified = new Date($("#DateModified").val());
    article.Title = $("#Title").val();
    article.Description = $("#Description").val();
    article.Content = editor.getHTMLCode();
    article.Thumb = $("#Thumb").val();
    article.Category = Number($("#Category").val());
    article.Status = Number($("#Status").val());

    // var test = new Date(article.DateCreate);
    // var result = convertTZ(test, "Asia/Jakarta")
    // alert(result);
    // alert(new Date(article.DatePublish, convertTZ(date, "Asia/Jakarta")));
    // alert(new Date(article.DateModified, convertTZ(date, "Asia/Jakarta")));

    console.log(article)
    $.ajax({
        type: "POST",
        url: "/cp/article/update",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(article),
        success: function (result) {
            if (result == "Ok!")
                document.location = "/cp";
        }
    })
}



function CheckImage() {
    var urlImage = $("#Thumb").val();
    $("#previewImageThumb").html(`<img src="${urlImage}" />`);
}

function Edit(id) {
    document.location = `/cp/article/edit?id=${id}`;
}

function Delete(id) {
    $.ajax({
        type: "GET",
        url: `/cp/article/delete?id=${id}`,
        success: function (result) {
            if (result == "Delete") {
                document.location = "/cp";
            }
        },
        onerror: function (message) {
            console.log(message);
        }
    })
}

function SaveImageCkEditor(e) {
    var urlAvatar = $("#AvatarCkeditor").val();
    var img = '<img src="' + urlAvatar + '" />&nbsp;';
    InsertHTML(img);
    $('modal').show('hide');
}


function ModalSave(whichModalSave, id) {
    var url = "";
    var urlCallBack = "";

    switch (whichModalSave) {
        case 0:
            url = "/cp/course/" + "add" + `?id=${id}`;
            urlCallBack = "/cp/course/";
            break;
        case 1:
            url = "/cp/lesson/" + "add" + `?id=${id}`;
            urlCallBack = "/cp/lesson/";
            break;
    }

    var title = $("#modelId #TitleModal").val();
    var obj = new Object();
    obj.Title = title;
    console.log(obj)
    $.ajax({
        type: "POST",
        url: `${url}`,
        data: JSON.stringify(obj),
        contentType: "application/json; charset=utf-8;",
        success: function (data) {
            $("#modelId").modal("hide");
            document.location = document.location.href;
        },
        onerror: function (e) {
            console.log(e);
        }
    })
}



function CallModal(url) {
    var id = $("#Id").val();
    $.ajax({
        type: "GET",
        url: `${url}${id}`,
        success: function (data) {
            $("#modelId .modal-content").html(data);
            $("#modelId").modal("show");
        },
        onerror: function (e) {
            console.log(e);
        }
    })
}

function UpdateTopic() {
    var obj = new Object();
    obj.Id = $("#Id").val();
    obj.Url = $("#Url").val();
    obj.DateCreated = new Date($("#DateCreated").val());
    obj.DateModified = new Date($("#DateModified").val());
    obj.Title = $("#Title").val();
    obj.Description = $("#Description").val();
    obj.Body = CKEDITOR.instances.editor.getData();
    obj.Category = Number($("#Category").val());
    // var data = 
    // console.log(data);
    console.log(obj);
    $.ajax({
        type: "POST",
        url: "/cp/topic/update",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(obj),
        success: function (result) {
            if (result == "Ok!")
                document.location = "/cp";
        }
    })
}

function UpdateCourse() {
    var obj = new Object();
    obj.Id = $("#Id").val();
    obj.Url = $("#Url").val();
    obj.DateCreated = new Date($("#DateCreated").val());
    obj.DateModified = new Date($("#DateModified").val());
    obj.Title = $("#Title").val();
    console.log(obj);
    $.ajax({
        type: "POST",
        url: "/cp/course/update",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(obj),
        success: function (result) {
            if (result == "OK")
                document.location = document.location.href;
        }
    })
}

function UpdateLesson() {
    var obj = new Object();
    obj.Id = $("#Id").val();
    obj.Url = $("#Url").val();
    obj.Order = $("#Order").val();
    obj.DateCreated = new Date($("#DateCreated").val());
    obj.DateModified = new Date($("#DateModified").val());
    obj.Title = $("#Title").val();
    obj.Status = Number($("#Status").val());
    obj.Body = CKEDITOR.instances.editor.getData();
    console.log(obj);
    $.ajax({
        type: "POST",
        url: "/cp/lesson/update",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(obj),
        success: function (result) {
            if (result == "OK")
                document.location = document.location.href;
        }
    })
}

function AddLesson(e) {
    e.preventDefault();
    var url = "/cp/lesson/getmodal?id=";
    CallModal(url);
}


function AddCourse(e) {
    e.preventDefault();
    var url = "/cp/course/getmodal?id=";
    CallModal(url);
}

function RemoveLesson(id, e) {
    e.preventDefault();
    $.ajax({
        type: "GET",
        url: `/cp/lesson/delete?id=${id}`,
        success: function (data) {
            if (data == "OK") {
                document.location = document.location.href;
            }
        },
        onerror: function (e) {
            console.log(e);
        }
    })
}


function RemoveCourse(id, e) {
    e.preventDefault();
    $.ajax({
        type: "GET",
        url: `/cp/course/delete?id=${id}`,
        success: function (data) {
            if (data == "OK") {
                document.location = document.location.href;
            }
        },
        onerror: function (e) {
            console.log(e);
        }
    })
}



function EditLesson(id, e) {
    e.preventDefault();
    window.location.href = `/cp/lesson/Index?id=${id}`;
}

function EditCourse(id, e) {
    e.preventDefault();
    window.location.href = `/cp/course/Index?id=${id}`;

}

function DoYouWantToDelete() {
    Swal.fire({
        title: 'Do you want to delete the record?',
        showDenyButton: true,
        showCancelButton: true,
        confirmButtonText: 'Save',
        denyButtonText: `Don't save`,
    }).then((result) => {
        if (result.isConfirmed) {
            return true;
        } else if (result.isDenied) {
            return false;
        }
    })
}