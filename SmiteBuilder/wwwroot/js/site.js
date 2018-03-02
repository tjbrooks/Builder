// Javascript lives here
$(document).ready(function () {
    $('[data-toggle="popover"]').popover();
});

$("img").on("error", function () {
    var src = $(this).attr("src");
    src = src.slice(src.lastIndexOf("/"));
    src = "/images" + src;
    $(this).attr("src", src);
});