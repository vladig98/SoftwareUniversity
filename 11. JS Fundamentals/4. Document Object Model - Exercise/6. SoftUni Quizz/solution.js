function solve() {
	let question1section = document.getElementsByTagName("section")[0];
	let question2section = document.getElementsByTagName("section")[1];
	let question3section = document.getElementsByTagName("section")[2];

	let question1inputs = document.getElementsByName("softUniYear");
	let question2inputs = document.getElementsByName("popularName");
	let question3inputs = document.getElementsByName("softUniFounder");

	let question1Button = document.getElementsByTagName("button")[0];
	let question2Button = document.getElementsByTagName("button")[1];
	let question3Button = document.getElementsByTagName("button")[2];

	let resultEl = document.getElementById("result");

	let result = 0;

	question1Button.addEventListener("click", function() {
		if ([...question1inputs].filter(function(x) { return x.checked && !x.disabled }).length > 0) {
			for (let i = 0; i < question1inputs.length; i++) {
				question1inputs[i].disabled = true;
			}

			if ([...question1inputs].filter(function(x) { return x.checked })[0].value == "2013") {
				result++;
			}

			question2section.classList.remove("hidden");
		}
	});

	question2Button.addEventListener("click", function() {
		if ([...question2inputs].filter(function(x) { return x.checked && !x.disabled }).length > 0) {
			for (let i = 0; i < question2inputs.length; i++) {
				question2inputs[i].disabled = true;
			}

			if ([...question2inputs].filter(function(x) { return x.checked })[0].value == "Pesho") {
				result++;
			}

			question3section.classList.remove("hidden");
		}
	});

	question3Button.addEventListener("click", function() {
		if ([...question3inputs].filter(function(x) { return x.checked && !x.disabled }).length > 0) {
			for (let i = 0; i < question3inputs.length; i++) {
				question3inputs[i].disabled = true;
			}

			if ([...question3inputs].filter(function(x) { return x.checked })[0].value == "Nakov") {
				result++;
			}

			if (result == 3) {
				resultEl.innerHTML = `You are recognized as top SoftUni fan!`;
			}
			else {
				resultEl.innerHTML = `You have ${result} right answers`;
			}
		}
	});
}