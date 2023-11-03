function solve() {
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let a = JSON.parse(arr.value);
  let r = [];

  for (let i = 0; i < a.length; i++) {
    if (i % 2 == 0) {
      r.push(a[i]);
    }
  }

  result.innerHTML = r.join(" x ");
}