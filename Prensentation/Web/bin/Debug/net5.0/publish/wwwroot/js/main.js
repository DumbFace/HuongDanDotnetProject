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

var editor = new RichTextEditor("#editor");

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