function solve() {
  let furniturelist = document.getElementById('furniture-list');
  let textareas = document.getElementsByTagName('textarea');
  let generateArea = textareas[0];
  let buyArea = textareas[1];

  let buttons = document.getElementsByTagName('button');
  let generate = buttons[0];
  let buy = buttons[1];

  generate.addEventListener("click", function() {
    let arr = JSON.parse(generateArea.value);

    for (let i = 0; i < arr.length; i++) {
      let div = document.createElement('div');
      div.classList.add("furniture");
      let p = document.createElement("p");
      p.innerHTML = `Name: ${arr[i]["name"]}`;
      div.appendChild(p);
      let img = document.createElement("img");
      img.setAttribute("src", arr[i]["img"]);
      div.appendChild(img);
      let p1 = document.createElement("p");
      p1.innerHTML = `Price: ${arr[i]["price"]}`;
      div.appendChild(p1);
      let p2 = document.createElement("p");
      p2.innerHTML = `Decoration factor: ${arr[i]["decFactor"]}`;
      div.appendChild(p2);
      let input = document.createElement("input");
      input.setAttribute("type", "checkbox");
      input.setAttribute("checked", true);
      div.appendChild(input);
      furniturelist.appendChild(div);
    }
  });
  
  buy.addEventListener("click", function() {
    let checkboxes = document.querySelectorAll("input[type='checkbox']");

    if ([...checkboxes].filter(x => x.checked).length > 0) {
      let names = [...checkboxes].map(function(x) {
        if (x.checked) {
          let parent = x.parentElement;
          let children = parent.children;
          return children[0].innerHTML.split(":").filter(Boolean)[1].trim();
        }
      }).filter(Boolean);

      let prices = [...checkboxes].map(function(x) {
        if (x.checked) {
          let parent = x.parentElement;
          let children = parent.children;
          return Number(children[2].innerHTML.split(":").filter(Boolean)[1].trim());
        }
      }).filter(Boolean);

      let factors = [...checkboxes].map(function(x) {
        if (x.checked) {
          let parent = x.parentElement;
          let children = parent.children;
          return Number(children[3].innerHTML.split(":").filter(Boolean)[1].trim());
        }
      }).filter(Boolean);

      buyArea.innerHTML = `Bought furniture: ${names.join(", ")}\n`;
      buyArea.innerHTML += `Total price: ${prices.reduce((a, b) => a + b).toFixed(2)}\n`;
      buyArea.innerHTML += `Average decoration factor: ${(factors.reduce((a, b) => a + b) / factors.length).toFixed(2)}`;
    }
  });
}