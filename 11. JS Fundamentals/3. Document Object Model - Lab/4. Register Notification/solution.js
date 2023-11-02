 function register() {
  let usernameInput = document.getElementById("username");
  let passwordInput = document.getElementById("password");
  let emailInput = document.getElementById("email");

  if (usernameInput.value && passwordInput.value && emailInput.value.match(/(.+)@(.+).(com|bg)/gm) != null) {
    let result = document.getElementById("result");
    let h1 = document.createElement("h1");
    h1.innerHTML = `Successful Registration!`;

    let br = document.createElement("br");

    result.appendChild(h1);
    result.innerHTML += `Username: ${usernameInput.value}`;
    result.appendChild(br);
    result.innerHTML += `Email: ${emailInput.value}`;
    result.appendChild(br);
    result.innerHTML += `Password: ${"*".repeat(passwordInput.value.length)}`;

    setTimeout(function() {
      result.innerHTML = ""
    }, 5000);
  }
 }
