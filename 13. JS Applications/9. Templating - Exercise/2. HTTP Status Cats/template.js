$(() => {
    renderCatTemplate();

    async function renderCatTemplate() {
        const source = await $('#cat-template').text();
        const template = Handlebars.compile(source)
        const context = { cats };
        const html = template(context);
        $('#allCats').html(html)
    }
})

function showDetails(id) {
    $(`#${id}`).toggle()
}
