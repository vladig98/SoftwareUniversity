function solve() {
	let encodeButton = document.getElementsByTagName("button")[0];
	let decodeButton = document.getElementsByTagName("button")[1];

	let senderTextArea = document.getElementsByTagName("textarea")[0];
	let receiverTextArea = document.getElementsByTagName("textarea")[1];

	encodeButton.addEventListener("click", function() {
		let text = senderTextArea.value;

		let chars = text.split("");

		for (let i = 0; i < chars.length; i++)
		{
			chars[i] = String.fromCharCode(chars[i].charCodeAt(0) + 1)
		}

		receiverTextArea.value = chars.join("");
	});

	decodeButton.addEventListener("click", function() {
		let text = receiverTextArea.value;

		let chars = text.split("");

		for (let i = 0; i < chars.length; i++)
		{
			chars[i] = String.fromCharCode(chars[i].charCodeAt(0) - 1)
		}

		receiverTextArea.value = chars.join("");
	});
}