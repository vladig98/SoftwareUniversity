function Solve(input) {
	let printKey = input[input.length - 1];
	
	let arr = [];
	
	for (let i = 0; i < input.length - 1; i++) {
		let key = input[i].split(' ')[0];
		let value = input[i].split(' ')[1];
		
		if (arr[key] == undefined) {
			arr[key] = [];
		}
		arr[key].push(value);
	}
	
	if (arr[printKey] == undefined) {
		console.log('None');
	} else {
		for (let i = 0; i < arr[printKey].length; i++) {
			console.log(arr[printKey][i]);
		}
	}
}