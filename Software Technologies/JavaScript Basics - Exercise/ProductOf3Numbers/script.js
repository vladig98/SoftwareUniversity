function Solve(input) {
	let negativeNumbers = input.filter(number => number < 0).length;
	
	if (negativeNumbers % 2 == 0) {
		return "Positive";
	} else {
		return "Negative";
	}
}