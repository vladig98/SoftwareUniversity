function Solve(input) {
	arr = [];
	
	for (let i = 0; i < input.length; i++) {
		let items = input[i].split(' -> ');
		let student = {'Name': items[0], 'Age': items[1], 'Grade': items[2]};
		arr.push(student);
	}
	
	for (let i = 0; i < arr.length; i++) {
		console.log('Name: ' + arr[i].Name);
		console.log('Age: ' + arr[i].Age);
		console.log('Grade: ' + arr[i].Grade);
	}
}