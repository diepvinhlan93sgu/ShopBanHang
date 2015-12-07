// Xử lý spam bài viết
function disableBtn(btnID, newText) {

    Page_IsValid = null;

    if (typeof (Page_ClientValidate) == 'function') {
        Page_ClientValidate();
    }

    var btn = document.getElementById(btnID);
    var isValidationOk = Page_IsValid;

    if (isValidationOk !== null) {

        if (isValidationOk) {
            btn.disabled = true;
            btn.value = newText;
            btn.style.background = "url(http://thunglunghoahong.com/Images/submiting.gif)";

        }
        else {
            btn.disabled = false;
        }
    }
    else {
        setTimeout("setImage('" + btnID + "')", 1000);
        btn.disabled = true;
        btn.value = newText;

    }
}

function setImage(btnID) {
    var btn = document.getElementById(btnID);
    btn.style.background = 'url(http://thunglunghoahong.com/Images/submiting.gif)';
}