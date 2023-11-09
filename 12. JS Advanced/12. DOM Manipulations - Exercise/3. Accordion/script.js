function toggle() {
    let extra = document.getElementById('extra');
    let span = document.getElementsByTagName('span')[0]

    if (span.innerHTML == "More") {
        extra.style.display = "block";
        span.innerHTML = "Less"
    } else {
        extra.style.display = "none";
        span.innerHTML = "More"
    }
}