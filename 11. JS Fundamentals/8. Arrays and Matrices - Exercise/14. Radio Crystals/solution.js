function solve() {
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let a = JSON.parse(arr.value);

  let desiredThickness = a.shift();

  for (let i = 0; i < a.length; i++) {
    let gem = a[i];

    let cuts = 0;

    let washP = document.createElement("p");
    washP.innerHTML = `Transporting and washing`;

    let p = document.createElement('p');
    p.innerHTML = `Processing chunk ${gem} microns`;
    result.appendChild(p);

    while (true) {
      if (gem / 4 >= desiredThickness) {
        cuts++;
        gem /= 4;
      }
      else {
        gem = Math.floor(gem);
        break;
      }
    }

    if (cuts != 0) {
      let cutsP = document.createElement("p");
      cutsP.innerHTML = `Cut x${cuts}`;
      result.appendChild(cutsP);
      result.appendChild(washP);
    }

    let laps = 0;

    while (true) {
      if (gem * 0.8 >= desiredThickness) {
        laps++;
        gem *= 0.8;
      }
      else {
        gem = Math.floor(gem);
        break;
      }
    }

    if (laps != 0) {
      let lapsP = document.createElement("p");
      lapsP.innerHTML = `Lap x${laps}`;
      result.appendChild(lapsP);
      result.appendChild(washP.cloneNode(true));
    }

    let grinds = 0;

    while (true) {
      if (gem - 20 >= desiredThickness) {
        grinds++;
        gem -= 20;
      }
      else {
        gem = Math.floor(gem);
        break;
      }
    }

    if (grinds != 0) {
      let grindP = document.createElement("p");
      grindP.innerHTML = `Grind x${grinds}`;
      result.appendChild(grindP);
      result.appendChild(washP.cloneNode(true));
    }

    let etches = 0;
    let xrays = 0;

    while (true) {
      if (gem - 2 >= desiredThickness) {
        etches++;
        gem -= 2;
      }
      else {
        gem = Math.floor(gem);
        if (gem - desiredThickness == 1) {
          etches++;
          gem--;
          xrays++;
        }
        break;
      }
    }

    if (etches != 0) {
      let etchesP = document.createElement("p");
      etchesP.innerHTML = `Etch x${etches}`;
      result.appendChild(etchesP);
      result.appendChild(washP.cloneNode(true));
    }

    if (xrays != 0) {
      let xraysP = document.createElement("p");
      xraysP.innerHTML = `X-ray x${xrays}`;
      result.appendChild(xraysP);
    }

    let resultP = document.createElement("p");
    resultP.innerHTML = `Finished crystal ${gem} microns`;
    result.appendChild(resultP);
  }
}