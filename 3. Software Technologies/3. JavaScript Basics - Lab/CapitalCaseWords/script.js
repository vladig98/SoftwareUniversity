function Solve(input){
	let result = [];
	
	for (let i = 0; i < input.length; i++) {
		let str = input[i];
		
		let words  = str.split(/[^a-zA-Z]/);
		
		for (let j = 0; j < words.length; j++) {
			if (words[j] == words[j].toUpperCase()) {
				result.push(words[j]);
			}
		}
	}
	
	var filtered = result.filter(function (el) {
		return el != null && el != '';
	});
	
	
	
	console.log(filtered.join(', '));
}