function solve(str) {

    function escapeHtml(unsafe)
    {
        return unsafe.toString()
            .replace(/&/g, "&amp;")
            .replace(/</g, "&lt;")
            .replace(/>/g, "&gt;")
            .replace(/"/g, "&quot;")
            .replace(/'/g, "&#039;");
    }
    
    let arr = JSON.parse(str);

    let keys = Object.keys(arr[0]);

    let table = document.createElement('table');
    let tr = document.createElement("tr");

    for (let i = 0; i < keys.length; i++) {
        let t = document.createElement("th");
        t.innerHTML = escapeHtml(keys[i]);
        tr.appendChild(t);
    }

    table.appendChild(tr);

    for (let i = 0; i < arr.length; i++) {
        let obj = arr[i];
        let t = document.createElement("tr");

        let values = Object.values(obj);
        
        for (let j = 0; j < values.length; j++) {
            let value = obj[keys[j]];

            let td = document.createElement("td");
            td.innerHTML = escapeHtml(value);
            t.appendChild(td);
        }

        table.appendChild(t);
    }

    console.log(table);
}