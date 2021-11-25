// When the user scrolls down 50px from the top of the document, resize the header's font size
//var prevScrollpos = window.pageYOffset;

//window.addEventListener("scroll", function () {
//    var currentScrollPos = window.pageYOffset;
//    if (prevScrollpos > currentScrollPos) {
//        document.getElementById("header").style.fontSize = "24px";
//        document.getElementById("header").style.position = "fixed";
//        document.getElementById("header").style.textAlign = "left";
//        document.getElementById("header").style.top = "30px";
//        document.getElementById("header").style.padding = "0px";
//    }
//    else {
//        document.getElementById("header").style.fontSize = "18px";
//        document.getElementById("header").style.position = "fixed";
//        document.getElementById("header").style.textAlign = "left";
//        document.getElementById("header").style.top = "0px";
//        document.getElementById("header").style.padding = "10px 20px";
//    }
//    if (currentScrollPos > 0) {
//        document.getElementById("header").style.backgroundColor = "white";
//    }
//    if (currentScrollPos <= 0) {
//        document.getElementById("header").style.backgroundColor = "transparent";
//    }
//    prevScrollpos = currentScrollPos;
//});