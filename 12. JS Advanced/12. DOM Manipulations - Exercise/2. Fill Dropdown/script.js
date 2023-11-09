function addItem() {
    let newItemText = document.getElementById('newItemText')
    let newItemValue = document.getElementById('newItemValue')
    let menu = document.getElementById('menu')

    let option = document.createElement('option')
    option.value = newItemValue.value;
    option.innerHTML = newItemText.value;

    menu.appendChild(option);
}