function solve() {
  let str = document.getElementById('str');
  let result = document.getElementById('result');

  let binary = str.value.split("");

  let sum = binary.map(function(x) { return Number(x)}).reduce(function(a, b) { return a + b });

  while (sum.toString().length != 1) {
    sum = sum.toString().split("").map(function(x) { return Number(x) }).reduce(function(a, b) { return a + b });
  }

  let s = str.value.substring(sum, str.value.length - (sum));
  let output = "";

  for (let i = 0; i < s.split("").length; i += 8) {
    let binaryNumber = s.substring(i, i + 8);
    output += String.fromCharCode(parseInt(binaryNumber, 2));
  }

  result.innerHTML = output;
}