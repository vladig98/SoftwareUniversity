function solve() {
    let arr = document.getElementById('arr');
    let result = document.getElementById('result');

    let a = JSON.parse(arr.value);
    let key = a.shift();
    let pattern = `\\b${key} {1,}([A-Z!%$#]{8,})(\\.| |,|$)`;
    let pattern2 = " {1,}([A-Z!%$#]{8,})(\\.| |,|$)";

    for (let i = 0; i < a.length; i++) {
        if (new RegExp(pattern, "gi").test(a[i])) {
          if (new RegExp(pattern2, "g").test(a[i])) {
            let mathces = a[i].match(new RegExp(pattern, "gi"));

            for (let k = 0; k < mathces.length; k++) {
              let message = new RegExp(pattern, "gi").exec(mathces[k])[1];
              
              let decoded = "";

              let letters = message.split("");

              for (let j = 0; j < letters.length; j++) {
                  if (letters[j].toString() == "!") {
                    decoded += "1";
                  }
                  else if (letters[j].toString() == "%") {
                    decoded += "2";
                  }
                  else if (letters[j].toString() == "#") {
                    decoded += "3";
                  }
                  else if (letters[j].toString() == "$") {
                    decoded += "4";
                  }
                  else {
                    decoded += letters[j].toString().toLowerCase();
                  }
              }

              a[i] = a[i].toString().replace(message, decoded);
            }

            
          }
        }

        let p = document.createElement("p");
        p.innerHTML = a[i];
        result.appendChild(p);
    }
}