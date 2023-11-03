function solve() {
  let num = document.getElementById('num');
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let a = JSON.parse(arr.value);
  let n = num.value;
  let r = [];

  for (let i = 0; i < a.length; i++) {
    let b = a[i].toString();

    if (b.includes(n)) {
      r.push(`true -> ${b.indexOf(n)}`);
    }
    else {
      r.push(`false -> -1`);
    }
  }

  result.innerHTML = r.join(", ");
}