function Solve(input) {
	let n = Number(input[0]);
	let x = Number(input[1]);
	
	if (n <= x) {
		return n * x;
	} else {
		return n / x;
	}
}