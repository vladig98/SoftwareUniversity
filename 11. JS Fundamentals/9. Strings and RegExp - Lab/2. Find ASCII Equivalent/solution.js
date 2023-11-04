function solve() {
  let str = document.getElementById('str');
  let result = document.getElementById('result');

  let arr = str.value.split(" ");
  let finalWord = "";

  for (let i = 0; i < arr.length; i++) {
    if (/\d+/g.test(arr[i])) {
      finalWord += String.fromCharCode(arr[i]);
    }
    else {
      let ascii = "";
      for (let j = 0; j < arr[i].split("").length; j++) {
        ascii += arr[i].split("")[j].charCodeAt(0) + " ";
      }
      let p = document.createElement("p");
      p.innerHTML = ascii;
      result.appendChild(p);
    }
  }

  let finalP = document.createElement('p');
  finalP.innerHTML = finalWord;
  result.appendChild(finalP);
}