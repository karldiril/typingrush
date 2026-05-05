const menu = document.getElementsByClassName("bouton")
const navMenu = document.getElementsByClassName("nav-menu")
let isOpen = false;


menu[0].addEventListener("click", ()=> {
    console.log("oui");
    if (!isOpen) {
        navMenu[0].classList.add("open");
        navMenu[0].classList.remove("close");
        isOpen = true;
    }

    else {
        navMenu[0].classList.remove("open");
        navMenu[0].classList.add("close");
        isOpen = false;
    }
});