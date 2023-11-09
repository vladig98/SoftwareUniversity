function validate() {

    let email = document.getElementById('email');

    email.addEventListener('change', function () {
        if (/[a-z]+@[a-z]+\.[a-z]+/g.test(email.value)) {
            this.classList.remove('error')
        }
        else {
            this.classList.add('error')
        }
    })
}