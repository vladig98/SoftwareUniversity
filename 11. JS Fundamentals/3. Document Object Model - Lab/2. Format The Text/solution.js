function solve() {
  let input = document.getElementById("input");
  let fullText = input.innerHTML;

  let sentences = fullText.split(".").filter(Boolean);

  let paragraphs = [];

  for (let i = 0; i < sentences.length; i += 3) {
    let paragraph = sentences[i] + '.';
    if (i + 1 < sentences.length) {
      paragraph += sentences[i + 1] + '.';
    }
    if (i + 2 < sentences.length) {
      paragraph += sentences[i + 2] + '.';
    }

    let p = document.createElement("p");
    p.innerHTML = paragraph;
    paragraphs.push(p);
  }

  let output = document.getElementById("output");

  for (let i = 0; i < paragraphs.length; i++) {
    output.appendChild(paragraphs[i]);
  }
}