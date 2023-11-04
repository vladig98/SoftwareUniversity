function solve() {
  let str = document.getElementById('str');
  let text = document.getElementById('text');
  let result = document.getElementById('result');

  let regex = "(north|east).{0,}?(\\d{2,2}).{0,}?,.{0,}?(\\d{6,6})";

  let matches = text.value.match(new RegExp(regex, "gi"));

  let east = "";
  let north = "";

  for (let i = matches.length - 1; i >= 0; i--) {
    let groups = new RegExp(regex, "gi").exec(matches[i]);

    let cordinate = groups[1].toString().toLowerCase();

    if (cordinate == "east") {
      if (east == "") {
        east = groups[2] + " " + groups[3];
      }
    }
    else {
      if (north == "") {
        north = groups[2] + " " + groups[3];
      }
    }
  }

  let message = new RegExp(`${str.value}(.+?)${str.value}`, "gi").exec(text.value)[1];

  let northP = document.createElement("p");
  northP.innerHTML = `${north.split(" ")[0]}.${north.split(" ")[1]} N`;
  result.appendChild(northP);

  let eastP = document.createElement("p");
  eastP.innerHTML = `${east.split(" ")[0]}.${east.split(" ")[1]} E`;
  result.appendChild(eastP);

  let messageP = document.createElement("p");
  messageP.innerHTML = `Message: ${message}`;
  result.appendChild(messageP);
}