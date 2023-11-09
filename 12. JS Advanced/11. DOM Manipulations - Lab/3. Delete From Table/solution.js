function deleteByEmail() {
    let result = document.getElementById('result');
    let input = document.getElementsByName('email')[0];

    let customers = document.getElementById('customers');
    let tbody = customers.children[0];
    let rows = tbody.children;

    let removed = false;

    for (let i = 0; i < rows.length; i++) {
        if (rows[i].innerHTML.includes(input.value)) {
            tbody.removeChild(rows[i])
            removed = true;
        }
    }

    if (!removed) {
        result.innerHTML = `Not found.`
    }
}