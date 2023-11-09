function create(sentences) {
    for (let i = 0; i < sentences.length; i++) {
        let div = document.createElement('div')
        let p = document.createElement('p')

        p.innerHTML = sentences[i]
        p.style.display = "none"

        div.addEventListener('click', function () {
            p.style.display = "block"
        })

        div.appendChild(p);
        document.getElementById('content').appendChild(div)
    }
}