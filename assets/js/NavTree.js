var navData;
var nav;
var pageTitle;
var backLinkWrapper;
var descLinkWrapper;

$(document).ready(function () {
    navData = $.parseJSON($('#navdata').html());
    nav = $('#navigation');
    pageTitle = $('#pagetitle');
    backLinkWrapper = $('#backLinkWrapper');
    descLinkWrapper = $('#descLinkWrapper');

    loadNav(0);
});

function loadNav(navIndex) {

    var tmpNav = GetNav(navIndex);

    nav.empty();

    pageTitle.empty();
    backLinkWrapper.empty();
    descLinkWrapper.empty();

    pageTitle.append('<p>' + tmpNav["title"] + '</p>');

    if (navIndex.length > 1) {
        var arr = navIndex.split(".");
        arr.pop();
        backLinkWrapper.append('<a href="#" onClick="loadNav(\'' + arr.join(".") + '\')"><i class="icon-chevron-sign-left"></i> <p>' + backString + '</p></a>');
    }

    if (tmpNav["type"] == "namespaceLink") {
        nav.append('<li><a class="sd-menudescription" onClick="SetDocSite(\'namespace/' + tmpNav["guid"] + '.html\')" href="#"><i class="icon-file-text-alt"></i> <p>' + descString + '</p></a></li>');
    }

    $.each(tmpNav["children"], function (key, value) {
        if (value["type"] == "placeholder" || value["type"] == "api") {
            nav.append('<li><a class="pagelink" onClick="loadNav(\'' + [navIndex, key].join(".") + '\')" href="#"><i class="icon-chevron-sign-right"></i> <p>' + value["title"] + '</p></a></li>');
        }
        else if (value["type"] == "link") {
            var navUrl = 'article/' + value["title"].replace(new RegExp(' ', 'g'), '_') + '.html';
            nav.append('<li><a class="pagelink" onClick="SetDocSite(\'' + navUrl + '\')" href="#' + navUrl + '"><i class="icon-link"></i> <p>' + value["title"] + '</p></a></li>');
        }
        else if (value["type"] == "namespaceLink") {
            nav.append('<li><a class="pagelink" onClick="loadNav(\'' + [navIndex, key].join(".") + '\'); SetDocSite(\'namespace/' + value["guid"] + '.html\')" href="#"><i class="icon-chevron-sign-right"></i> <p>' + value["title"] + '</p></a></li>');
        }
        else if (value["type"] == "typeLink") {
            var navUrl = 'type/' + value["guid"] + '.html';
            nav.append('<li><a class="pagelink" href="#' + navUrl + '" onClick="SetDocSite(\'' + navUrl + '\')"><i class="icon-link"></i> <p>' + value["title"] + '</p></a></li>');
        }
    });

    initNavWrap();
}

function SetDocSite(url) {
    $("#docFrame").attr('src', url);
}

function GetNav(navIndexKey) {
    var navIndices = navIndexKey.toString().split(".")
    var tmpNav = navData;
    $.each(navIndices, function (key, value) {
        tmpNav = tmpNav[value];
        if (key < navIndices.length - 1)
            tmpNav = tmpNav["children"];
    });

    return tmpNav;
}

function initNavWrap() {
    var items = $("#sidebar #navigation li a p");
    $.each(items, function (key, val) {
        var lineBreaks = $(val).width() / 240;
        if (lineBreaks > 1) {
            var parent = $(val).parent();
            var splittedText = $(val).html().split(".");
            var textIndex = 0;
            $(val).remove();
            for (var i = 0; i < lineBreaks; i++) {
                textIndex = createNewParagraph(parent, splittedText, textIndex);
            }
        }
    });
}

function createNewParagraph(parent, splittedText, textIndex) {
    var newP = $("<p>" + joinFromTillIndex(splittedText, textIndex, splittedText.length - 1) + "</p>");
    var newIndex = splittedText.length - 1;
    parent.append(newP);
    for (var i = splittedText.length - 1; i >= textIndex; i--) {
        if (newP.width() > 240) {
            newP.html(joinFromTillIndex(splittedText, textIndex, i));

            if (i + 1 != splittedText.length) {
                newP.html(newP.html() + ".");
            }

            newIndex = i;
        }
        else {
            break;
        }
    }
    newIndex++;
    return newIndex;
}

function joinFromTillIndex(array, from, till) {
    var text = "";
    for (var i = from; i <= till; i++) {
        text += array[i] + ".";
    }
    text = text.substring(0, text.length - 1);
    return text;
}