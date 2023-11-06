function getArticleGenerator(articles) {
    let func = function() {
        if (articles.length > 0) {
            let article = articles.shift();
            let div = document.createElement("article");
            div.innerHTML = article;
            document.getElementById("content").appendChild(div);
        }
    }

    return func;
}