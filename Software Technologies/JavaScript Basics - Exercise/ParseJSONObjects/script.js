function Solve(input) {
	arr = [];
	
	for (let i = 0; i < input.length; i++) {
		arr.push(JSON.parse(input[i]));
	}
	
	for (let i = 0; i < arr.length; i++) {
		console.log('Name: ' + arr[i].name);
		console.log('Age: ' + arr[i].age);
		console.log('Date: ' + arr[i].date);
	}
}