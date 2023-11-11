function attachEvents() {
    $('#btnLoadTowns').on('click', function () {
        let towns = $('#towns').val().split(', ')
        render(towns);
    })
}

async function render(towns) {
    const source = await $('#towns-template').text();
    const template = Handlebars.compile(source)
    const context = { towns };
    const html = template(context);
    $('#root').html(html)
}