allContent=$(".content").toArray();
slideIndex=0;

$(".nextSlide").click(function() {
    if (allContent.length==slideIndex+1) {
        slideIndex=-1
    }
    showSlide(++slideIndex);
})
$(".prevSlide").click(function() {
    if (slideIndex==0) {
        slideIndex=allContent.length
    }
    showSlide(--slideIndex);
})
function showSlide(n) {
    for (let i = 0; i < allContent.length; i++) {
        allContent[i].style.display="none";
        $(".number").eq(i).removeClass("active")
    }
    allContent[n].style.display="block";
    $(".number").eq(n).addClass("active")

}
$(".number").click(function() {
    slideIndex=$(this).index();
    showSlide(slideIndex)
})
showSlide(slideIndex);

$(".card").click(function() {
    $(".main-popup").css("display","block")
})
$(".main-popup").click(function() {
    $(".main-popup").css("display","none")
    
})