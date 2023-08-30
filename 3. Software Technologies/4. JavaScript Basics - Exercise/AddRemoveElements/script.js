function Solve(input) {
	let arr = [];
	
	for (let i = 0; i < input.length; i++) {
		let command = input[i].split(' ')[0];
		let argument = input[i].split(' ')[1];
		
		if (command == 'add') {
			arr.push(argument);
		} else {
			arr.splice(argument, 1);
		}
	}
	
	for (let i = 0; i < arr.length; i++) {
		console.log(arr[i]);
	}
}