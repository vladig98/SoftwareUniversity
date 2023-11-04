function solve() {
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let a = JSON.parse(arr.value);

  let dashes = document.createElement("p");
  dashes.innerHTML = "- - -";

  for (let i = 0; i < a.length; i++) {
    if (/^[A-Z]{1,1}[a-z]{0,} [A-Z]{1,1}[a-z]{0,} (\+359 \d{1,1} \d{3,3} \d{3,3}|\+359-\d{1,1}-\d{3,3}-\d{3,3}) [a-z0-9]+@[a-z]{1,}\.[a-z]{2,3}$/g.test(a[i])) {
      let name = document.createElement("p");
      name.innerHTML = `Name: ${a[i].match(/[A-Z]{1,1}[a-z]{0,} [A-Z]{1,1}[a-z]{0,}/g)}`;
      result.appendChild(name);

      let phone = document.createElement("p");
      phone.innerHTML = `Phone Number: ${a[i].match(/(\+359 \d{1,1} \d{3,3} \d{3,3}|\+359-\d{1,1}-\d{3,3}-\d{3,3})/g)}`;
      result.appendChild(phone);

      let email = document.createElement("p");
      email.innerHTML = `Email: ${a[i].match(/[a-z0-9]+@[a-z]{1,}\.[a-z]{2,3}/g)}`;
      result.appendChild(email);

      result.appendChild(dashes.cloneNode(true));
    }
    else {
      let p = document.createElement("p");
      p.innerHTML = "Invalid data";
      result.appendChild(p);
      result.appendChild(dashes.cloneNode(true));
    }
  }
}