function solve() {
   let num = document.getElementById('num');
   let result = document.getElementById('result');

   let number = Number(num.value);
   let arr = [];

   for (let i = 1; i <= Math.floor(Math.sqrt(number)); i++) {
      if (number % i == 0) {
         arr.push(i);
         arr.push(number / i);
      }
   }

   arr = arr.sort(function(a, b) { return a - b; });

   result.innerHTML = arr.join(" ");
}