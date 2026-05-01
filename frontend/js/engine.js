let jeu = document.querySelectorAll("span");

let i = 0;
jeu[i].classList.add("actif");

document.body.addEventListener("keydown", (input) => {
    console.log("test");
    if (input.key.length == 1) {
        if (input.key == jeu[i].textContent) {
            jeu[i].classList.add("correct");
        }
        else {
            jeu[i].classList.add("incorrect");
        }
        jeu[i].classList.remove("actif");
        ++i;
        
    }
})