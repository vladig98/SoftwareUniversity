function attachEvents() {
	$('ul#items li').on("click", function () {
		if ($(this).attr("data-selected")) {
			$(this).removeAttr("data-selected")
			$(this).css("background-color", "");
		} else {
			$(this).attr("data-selected", true)
			$(this).css("background-color", "#DDD");
		}
	});

	$('button#showTownsButton').on("click", function () {
		$('div#selectedTowns').text([...$('ul#items li[data-selected=true]')].map(x => x.textContent).join(", "))
	})
}