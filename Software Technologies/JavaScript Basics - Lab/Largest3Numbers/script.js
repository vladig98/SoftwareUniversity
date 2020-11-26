function Solve(input) {
	let nums = [];
	//nums.push(0);
	
	Array.min = function (array){
		return Math.min.apply( Math, array );
	};
	
	for	(let i = 0; i < input.length; i++) {
		let number = Number(input[i]);
		if (nums.length == 3) {
			let num = Array.min(nums);
			if (number > num) {
				let index = nums.indexOf(num);
				nums[index] = number;
			}
		} else {
			nums.push(number);
		}
	}
	
	nums.sort((a, b) => b - a);
	
	for (let i = 0; i < nums.length; i++) {
		console.log(nums[i]);
	}
}