function Solve(input) {
	let n = input[0];
	
	let arr = [];
	
	for (let i = 0; i < n; i++) {
		arr[i] = 0;
	}
	
	for (let i = 1; i < input.length; i++) {
		let element = input[i];
		let index = element.split(' - ')[0];
		let value = element.split(' - ')[1];
		
		arr[index] = value;
	}
	
	for (let i = 0; i < n; i++) {
		console.log(arr[i]);
	}
}