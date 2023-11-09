function addItem() {
    let input = document.getElementById('newText');
    let list = document.getElementById('items');

    let li = document.createElement('li');
    li.innerHTML = input.value

    let button = document.createElement('a');
    button.setAttribute("href", "#")
    button.innerHTML = "[Delete]"
    button.style.marginLeft = "20px";
    li.appendChild(button);

    button.addEventListener("click", deleteItem);

    list.appendChild(li);

    function deleteItem() {
        let parent = this.parentNode;
        list.removeChild(parent);
    }
}