function addItem() {
    let input = document.getElementById('newItemText');
    let list = document.getElementById('items');

    let li = document.createElement('li');
    li.innerHTML = input.value

    list.appendChild(li);
}