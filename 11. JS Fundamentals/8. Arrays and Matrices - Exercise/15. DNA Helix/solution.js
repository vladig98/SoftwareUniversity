function solve() {
  let num = document.getElementById('num');
  let result = document.getElementById('result');

  let limit = Number(num.value);

  let symbols = ["A", "T", "C", "G", "T", "T", "A", "G", "G", "G"];
  let index = 0;

  for (let i = 0; i < limit; i++) {
    let p = document.createElement("p");
    if (i % 4 == 0) {
      p.innerHTML = `**${symbols[index++ % symbols.length]}${symbols[index++ % symbols.length]}**`;
    }
    else if (i % 4 == 1 || i % 4 == 3) {
      p.innerHTML = `*${symbols[index++ % symbols.length]}--${symbols[index++ % symbols.length]}*`;
    }
    else if (i % 4 == 2) {
      p.innerHTML = `${symbols[index++ % symbols.length]}----${symbols[index++ % symbols.length]}`;
    }

    result.appendChild(p);
  }
}