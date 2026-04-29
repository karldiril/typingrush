let jeu = document.querySelectorAll("span");


let i = 0;

document.body.addEventListener("keydown", (input) => {
    if (input.key.length == 1){
        if (jeu[i].textContent == input.key) {
        console.log("Oui")
        jeu[i].classList.add('bon');
    }
    else {
        console.log("Non");
        jeu[i].classList.add('erreur');
    }
    i += 1
    }
})