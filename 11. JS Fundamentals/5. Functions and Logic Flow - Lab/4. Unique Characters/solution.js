function solve() {
  let string = document.getElementById('string');
  let result = document.getElementById('result');

  let chars = string.value.split("");

  let arr = [];

  for (let i = 0; i < chars.length; i++) {
    if (/\S/g.test(chars[i])) {
      if (!arr.includes(chars[i])) {
        arr.push(chars[i]);
      }
    }
    else {
      arr.push(chars[i]);
    }
  }

  result.innerHTML = arr.join("");
}