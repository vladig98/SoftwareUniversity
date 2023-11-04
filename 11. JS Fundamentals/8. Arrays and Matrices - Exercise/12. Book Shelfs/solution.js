function solve() {
  let arr = document.getElementById('arr');
  let result = document.getElementById('result');

  let info = JSON.parse(arr.value);

  let shelves = [];

  for (let i = 0; i < info.length; i++) {
    if (info[i].split("->").filter(Boolean).length > 1) {
      let shelfId = info[i].split("->").filter(Boolean)[0].trim();
      let genre = info[i].split("->").filter(Boolean)[1].trim();

      if (!shelves.some(x => x[0] == shelfId)) {
        if (!shelves.some(x => x[1] == genre)) {
          shelves.push([shelfId, genre, []]);
        }
      }
    }
    else {
      let bookTitle = info[i].split(":").filter(Boolean)[0].trim();
      let author = info[i].split(":").filter(Boolean)[1].split(",").filter(Boolean)[0].trim();
      let genre = info[i].split(",").filter(Boolean)[1].trim();

      if (shelves.some(x => x[1] == genre)) {
        shelves.filter(function(x) {
          return x[1] == genre;
        })[0][2].push([bookTitle, author]);
      }
    }
  }

  for (let i = 0; i < shelves.length; i++) {
    shelves[i][2].sort(function(a, b) {
      return a - b;
    });
  }

  shelves.sort(function(a, b) {
    if (a[2].length < b[2].length) {
      return 1;
    }
    else if (a[2].length > b[2].length) {
      return -1;
    }
    else {
      return 0;
    }
  });

  for (let i = 0; i < shelves.length; i++) {
    let p = document.createElement("p");
    p.innerHTML = `${shelves[i][0]} ${shelves[i][1]}: ${shelves[i][2].length}`;
    result.appendChild(p);

    for (let j = 0; j < shelves[i][2].length; j++) {
      let newp = document.createElement("p");
      newp.innerHTML = `--> ${shelves[i][2][j][0]}: ${shelves[i][2][j][1]}`;
      result.appendChild(newp);
    }
  }
}