function solve() {
  let num1 = document.getElementById("num1");
  let type = document.getElementById("type");

  let result = document.getElementById("result");

  if (isNaN(Number(num1.value)) || (type.value.toLowerCase() != "celsius" && type.value.toLowerCase() != "fahrenheit")) {
    result.innerHTML = "Error!";
  }
  else {
    if (type.value.toLowerCase() == "celsius") {
      result.innerHTML = Math.round(Number(num1.value) * 9/5 + 32);
    }
    else {
      result.innerHTML = Math.round((Number(num1.value) - 32) * 5/9);
    }
  }
}