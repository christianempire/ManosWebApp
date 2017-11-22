// Home JavaScript code

var HomeViewModel = function () {
  var self = this;

  $(document).ready(function () {
    // Initialize owl carousel
    $(".owl-carousel").owlCarousel({
      items: 1,
      loop: true,
      autoplay: true,
      nav: true,
      navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>']
    });
  });

  return self;
}
