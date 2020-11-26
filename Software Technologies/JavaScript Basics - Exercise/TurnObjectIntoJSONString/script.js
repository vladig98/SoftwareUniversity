function Solve(input) {
	let obj = {};
	
	for (let i = 0; i < input.length; i++) {
		let items = input[i].split(' -> ');
		let newItems = items.slice();
		let isNumber = Number(newItems[1]);
		
		if (isNumber == null || isNumber == undefined || Number.isNaN(isNumber)) {
			obj[items[0]] = items[1];
		}else {
			obj[items[0]] = Number(items[1]);
		}
	}
	
	console.log(JSON.stringify(obj));
}