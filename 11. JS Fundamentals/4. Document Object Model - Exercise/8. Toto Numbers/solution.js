function solve() {
	let numbersInput = document.getElementsByTagName("input")[0];
	let button = document.getElementsByTagName("button")[0];

	let allNumbers = document.getElementById("allNumbers");

	button.addEventListener("click", function() {
		let numbers = numbersInput.value.split(" ").filter(Boolean);

		if (numbers.length == 6) {
			if (numbers.filter(function(x) { return x >= 1 && x <= 49 }).length == 6) {
				if (numbers.filter(function onlyUnique(value, index, array) { return array.indexOf(value) === index; }).length == 6) {
					for (let i = 1; i <= 49; i++) {
						let div = document.createElement("div");
						div.classList.add("numbers");
						div.innerHTML = i;

						if (numbers.filter(function(x) { return Number(x) == i}).length > 0) {
							div.style.backgroundColor = "orange";
						}

						allNumbers.appendChild(div);
					}

					numbersInput.disabled = true;
					button.disabled = true;
				}
			}
		}
	});
}