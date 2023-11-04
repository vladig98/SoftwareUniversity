function solve() {
  let str = document.getElementById('str');
  let num = document.getElementById('num');
  let result = document.getElementById('result');

  let arr = str.value.split("");
  let n = Number(num.value);

  let final = "";

  for (let i = 0; i < arr.length; i += n) {
    for (let j = i; j < i + n; j++) {
      final += arr[j % arr.length];
    }
    final += " ";
  }

  result.innerHTML = final;
}