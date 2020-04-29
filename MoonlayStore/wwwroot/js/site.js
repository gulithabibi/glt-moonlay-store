// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

jQuery(document).ready(function (e) {
    
    jQuery("#search-button").on("click", function () {
        var str = jQuery("#search-input").val();
        
        if (str == "" || str.length == 0) {

        } else {
            show_loader();
            jQuery.ajax({
                url: 'https://localhost:44307/Product/Search',
                type: 'get',
                dataType: 'html',
                data: { str: str },
                success: function (data) {
                    //console.log(data);
                    hide_loader();
                    jQuery("#product-list").html(data);
                },
                error: function (data) {
                    hide_loader();
                    console.log(data);
                    jQuery("#product-list").html(data);

                }
            });
        }
    });
    
});

function img_selected(e) {
    var url = jQuery(e).data("url");
    jQuery("#imgTag").html("<img src='"+url+"'>");
}


function show_loader() {
    jQuery(".overlay").show();
}

function hide_loader() {
    jQuery(".overlay").hide();
}

function AJAXGet(targetUrl,formId,placeHolder) {
    jQuery.ajax({
        url: targetUrl,
        type: 'GET',
        dataType: 'html',
        data: jQuery('#' + formId).serialize(),
        success: function (e) {
            jQuery('#' + placeHolder).html(e);
        },
        error: function (e) {

        }
    })
}

function AJAXPost(targetUrl, formId, placeholderId) {
    var status = false;
    //jQuery("#wait").css("display","block");  
    show_loader();
    jQuery.ajax({
        url: targetUrl,
        type: 'post',
        cache: false,
        aync: true,
        dataType: "html",
        data: jQuery('#' + formId).serialize(),
        success: function (data) {
            jQuery('#' + placeholderId).html(data)
            hide_loader();
            //jQuery("#wait").css("display","none"); 

            status = true;
        },
        error: function (ex) {
            console.log(ex.message);
        }
    });

    return status;
}