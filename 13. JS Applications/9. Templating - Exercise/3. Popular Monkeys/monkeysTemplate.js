$(() => {
    render();

    async function render() {
        const source = await $('#monkey-template').text();
        const template = Handlebars.compile(source)
        const context = { monkeys };
        const html = template(context);
        $('.monkeys').html(html)
    }
})

function showDetails(id) {
    $(`#${id}`).toggle()
}