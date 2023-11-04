function solve() {
  let str1 = document.getElementById('str1');
  let str2 = document.getElementById('str2');
  let result = document.getElementById('result');

  if (/camel case/gi.test(str2.value)) {
    let arr = str1.value.split(" ").filter(Boolean).map(function(x) { return x.toString().toLowerCase() });
    let r = arr[0].toString();

    for (let i = 1; i < arr.length; i++) {
      r += arr[i].split("")[0].toString().toUpperCase() + arr[i].slice(1);
    }

    result.innerHTML = r;
  }
  else if (/pascal case/gi.test(str2.value)) {
    let arr = str1.value.split(" ").filter(Boolean).map(function(x) { return x.toString().toLowerCase() });
    let r = ""

    for (let i = 0; i < arr.length; i++) {
      r += arr[i].split("")[0].toString().toUpperCase() + arr[i].slice(1);
    }

    result.innerHTML = r;
  }
  else {
    result.innerHTML = "Error!";
  }
}