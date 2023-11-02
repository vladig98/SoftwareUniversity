function solve() {
  let num1 = document.getElementById("num1");
  let num2 = document.getElementById("num2");

  let result = document.getElementById("result");

  if (Number(num1.value) > Number(num2.value)) {
    result.innerHTML = "Try with other numbers.";
  }
  else {
    result.innerHTML = '';
    for (let i = Number(num1.value); i <= Number(num2.value); i++) {
      let p = document.createElement("p");
      p.innerHTML = `${i} * ${num2.value} = ${i * Number(num2.value)}`;

      result.appendChild(p);
    }
  }
}