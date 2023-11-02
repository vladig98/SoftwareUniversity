function solve() {
  let string = document.getElementById('string');
  let character = document.getElementById('character');
  let result = document.getElementById('result');

  let arr = string.value.split("");
  let counter = 0;

  for (let i = 0; i < arr.length; i++) {
    if (arr[i] == character.value) {
      counter++;
    }
  }

  result.innerHTML = counter % 2 == 0 ? `Count of ${character.value} is even.` : `Count of ${character.value} is odd.`;
}