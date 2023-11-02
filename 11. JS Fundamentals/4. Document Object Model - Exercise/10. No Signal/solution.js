function solve() {
	let w = Math.round((Math.random() * 81) + 1);
	let h = Math.round((Math.random() * 45) + 1);

	let div = document.getElementById("exercise").children[0];

	div.style.marginLeft = `${w}%`;
	div.style.marginTop = `${h}vh`;

	setTimeout(solve, 2000);
}