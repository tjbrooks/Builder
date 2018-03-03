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

var elem = document.querySelector('.grid');
var msnry = new Masonry(elem, {
    // options
    itemSelector: '.grid-item',
    columnWidth: 200
});

// element argument can be a selector string
//   for an individual element
var msnry = new Masonry('.grid', {
    // options
});

var $grid = $('.grid').masonry({
    columnWidth: 120,
    itemSelector: '.grid-item',
    percentPosition: true
});

$grid.on('click', '.grid-item-content', function (event) {
    $(event.currentTarget).parent('.grid-item').toggleClass('is-expanded');
    $grid.masonry();
});
