function solve() {
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let a = JSON.parse(arr.value);
  let r = [];

  for (let i = 0; i < a.length; i++) {
    let reversed = a[i].split("").reverse().join("");
    reversed = reversed.charAt(0).toUpperCase() + reversed.slice(1);

    r.push(reversed);
  }

  result.innerHTML = r.join(" ");
}