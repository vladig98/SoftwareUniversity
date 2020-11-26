function Solve(input) {
	let printKey = input[input.length - 1];
	
	let arr = [];
	
	for (let i = 0; i < input.length - 1; i++) {
		let key = input[i].split(' ')[0];
		let value = input[i].split(' ')[1];
		
		arr[key] = value;
	}
	
	if (arr[printKey] == undefined) {
		console.log('None');
	} else {
		console.log(arr[printKey]);
	}
}