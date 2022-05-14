$(document).ready(function(){
    
   $(window).on('scroll',function () {
   console.log(document.documentElement.scrollTop)
    if (document.documentElement.scrollTop==0) {
    $(".top").css(
        "border-bottom","0px solid #f06730"
       );
       $("#togle1").css({
        cssText: "display: none !important"
    });
}
    else{
        $(document).ready(function () {
            $(".top").css("border-bottom","5px solid #f06730");
            $("#togle1").css({cssText: "display: inline !important"});
        });
    }



       


})

   

 $(".search-button").click(function(e) {
     $("#textbox").css("display","inline")
     $(".searchbutton").css("display","inline")
     $(".search-button").css("display","none")
     e.preventDefault();
 })
 $("section").click(function(e) {
    $("#textbox").css("display","none")
    $(".searchbutton").css("display","none")
    $(".search-button").css("display","inline")
    e.preventDefault();
})
$("#offcanvasNavbar").click(function() {
    $(".offcanvas").addClass("show")
})
})

 
