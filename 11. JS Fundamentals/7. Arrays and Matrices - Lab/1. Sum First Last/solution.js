function solve() {
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let a = JSON.parse(arr.value);

  for (let i = 0; i < a.length; i++) {
    let p = document.createElement("p");
    p.innerHTML = `${i} -> ${Number(a[i]) * a.length}`;

    result.appendChild(p);
  }
}