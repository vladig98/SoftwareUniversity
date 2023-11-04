function solve() {
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let ba = 0;
  let cp = 0;
  let d = 0;
  let f = 0;
  let t = 0;
  let s = 0;
  let p = 0;
  let o = 0;

  let a = JSON.parse(arr.value);

  for (let i = 0; i < a.length; i++) {
    let token = a[i];

    if (/^BA \d{3,3} \d{3,3}$/gm.test(token)) {
      ba++;
    }
    else if (/^CP \d{2,2} \d{3,3}$/gm.test(token)) {
      cp++;
    }
    else if (/^(C|CA|CB) \d{4,4} [a-zA-Z]{1,2}$/gm.test(token)) {
      s++;
    }
    else if (/^(C|CT) \d{4,4}$/gm.test(token)) {
      d++;
    }
    else if (/^XX \d{4,4}$/gm.test(token)) {
      f++;
    }
    else if (/^\d{3,3} [a-zA-Z]{1,1} \d{3,3}$/gm.test(token)) {
      t++;
    }
    else if (/^(?!C|CA|CB|CT|BA|XX)[a-zA-Z]{1,2} \d{4,4} [a-zA-Z]{1,2}$/gm.test(token)) {
      p++;
    }
    else {
      o++;
    }
  }

  let r = {
    "BulgarianArmy": ba,
    "CivilProtection": cp,
    "Diplomatic": d,
    "Foreigners": f,
    "Other": o,
    "Province": p,
    "Sofia": s,
    "Transient": t
  };

  let sortable = [];
  for (var vehicle in r) {
      sortable.push([vehicle, r[vehicle]]);
  }

  sortable.sort(function(a, b) {
    // if (a[1] < b[1]) {
    //   return 1;
    // }
    // else if (a[1] > b[1]) {
    //   return -1;
    // }
    // else {
      if (a[0] < b[0]) {
        return -1;
      }
      else if (a[0] > b[0]) {
        return 1;
      }
      else {
        return 0;
      }
    //}
  });

  for (let i = 0; i < sortable.length; i++) {
    let p = document.createElement("p");
    p.innerHTML = `${sortable[i][0]} -> ${sortable[i][1]}`;
    result.appendChild(p);
  }
}