// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// When the user scrolls down, navbar dissapears
var prevScrollpos = window.pageYOffset;

window.addEventListener("scroll", function () {

    var currentScrollPos = window.pageYOffset;
    if (prevScrollpos > currentScrollPos && currentScrollPos == 0) {
        document.querySelector(".navbar").style.top = "0";
    }
    else {
        document.querySelector(".navbar").style.top = "-100px";
    }
    prevScrollpos = currentScrollPos;
});

// When the user scrolls down 50px from the top of the document, resize the header's font size
var prevScrollposi = window.pageYOffset;

window.addEventListener("scroll", function () {
    var currentScrollPos = window.pageYOffset;
    if (prevScrollposi > currentScrollPos && currentScrollPos == 0) {
        document.getElementById("header").style.fontSize = "24px";
        document.getElementById("header").style.position = "fixed";
        document.getElementById("header").style.textAlign = "left";
        document.getElementById("header").style.top = "70px";
        document.getElementById("header").style.padding = "0px";
        document.getElementById("header").style.marginLeft = "0%";
        document.getElementById("container").style.marginTop = "110px";
    }
    else {
        document.getElementById("header").style.fontSize = "18px";
        document.getElementById("header").style.position = "fixed";
        document.getElementById("header").style.textAlign = "left";
        document.getElementById("header").style.top = "0px";
        document.getElementById("header").style.padding = "10px 20px";
        document.getElementById("header").style.marginLeft = "-15%";
        document.getElementById("container").style.marginTop = "0px";
    }
    if (currentScrollPos > 0) {
        document.getElementById("header").style.backgroundColor = "white";
    }
    if (currentScrollPos <= 0) {
        document.getElementById("header").style.backgroundColor = "transparent";
    }
    prevScrollposi = currentScrollPos;
});