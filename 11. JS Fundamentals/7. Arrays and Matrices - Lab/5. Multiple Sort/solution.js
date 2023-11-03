function solve() {
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let a = JSON.parse(arr.value);

  a.sort(function(x, y) {
    return Number(x) - Number(y);
  });

  let div = document.createElement("div");
  div.innerHTML = a;

  result.appendChild(div);

  a.sort();

  let div2 = document.createElement("div");
  div2.innerHTML = a;

  result.appendChild(div2);
}