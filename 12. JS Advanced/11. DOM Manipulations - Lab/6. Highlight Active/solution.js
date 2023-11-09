function focus() {
    let input = document.getElementsByTagName('input');

    for (let i = 0; i < input.length; i++) {
        input[i].addEventListener("focusin", function () {
            this.parentElement.classList.add("focused");
        })

        input[i].addEventListener("focusout", function () {
            this.parentElement.classList.remove("focused")
        })
    }
}