function solve() {
	var title = document.getElementsByTagName("input")[0];
	var content = document.getElementsByTagName("textarea")[0];

	if (title.value && content.value) {
		var article = document.createElement("article");
		var h3 = document.createElement("h3");
		var p = document.createElement("p");

		h3.innerHTML = title.value;
		p.innerHTML = content.value;

		article.appendChild(h3);
		article.appendChild(p);

		document.getElementById("articles").appendChild(article);
	}

	title.value = '';
	content.value = '';
}