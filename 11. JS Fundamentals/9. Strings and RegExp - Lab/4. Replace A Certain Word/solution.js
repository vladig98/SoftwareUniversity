function solve() {
  let arr = document.getElementById('arr');
  let str = document.getElementById('str');
  let result = document.getElementById('result');

  let a = JSON.parse(arr.value);
  let word = a[0].split(" ")[2];

  let regex = new RegExp(word, "gi");

  for (let i = 0; i < a.length; i++) {
    a[i] = a[i].replace(regex, str.value);
    let p = document.createElement("p");
    p.innerHTML = a[i];
    result.appendChild(p);
  }
}