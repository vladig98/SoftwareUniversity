function attachGradientEvents() {
    let gradientBox = document.getElementById('gradient-box');
    let cords = gradientBox.getBoundingClientRect();
    let result = document.getElementById('result')
    let gradient = document.getElementById('gradient');
    gradient.addEventListener('click', function (e) {
        result.innerHTML = Math.floor(((e.x - cords.left) / (cords.right - cords.left)) * 100) + "%"
    })
}