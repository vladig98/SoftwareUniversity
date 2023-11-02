function solve() {
  let firstNumber = document.getElementById('firstNumber');
  let secondNumber = document.getElementById('secondNumber');
  let firstString = document.getElementById('firstString');
  let secondString = document.getElementById('secondString');
  let thirdString = document.getElementById('thirdString');
  let result = document.getElementById('result');

  for (let i = Number(firstNumber.value); i <= Number(secondNumber.value); i++) {
    let p = document.createElement("p");
    
    if (i % 3 == 0 && i % 5 == 0) {
      p.innerHTML = `${i} ${firstString.value}-${secondString.value}-${thirdString.value}`;
    }
    else if (i % 3 == 0) {
      p.innerHTML = `${i} ${secondString.value}`;
    }
    else if (i % 5 == 0) {
      p.innerHTML = `${i} ${thirdString.value}`;
    }
    else {
      p.innerHTML = i;
    }

    result.appendChild(p);
  }
}