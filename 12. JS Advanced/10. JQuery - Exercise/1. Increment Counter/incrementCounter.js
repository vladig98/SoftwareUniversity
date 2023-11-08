function increment(selector) {
    $(selector).append($('<textarea>').addClass("counter").val(0).attr('disabled', true))
        .append($('<button>').addClass('btn').attr('id', 'incrementBtn').text('Increment').on('click', function () {
            $('textarea.counter').val(Number($('textarea.counter').val()) + 1)
        }))
        .append($('<button>').addClass('btn').attr('id', 'addBtn').text('Add').on('click', function () {
            $('ul.results').append($('<li>').text($('textarea.counter').val()))
        }))
        .append($('<ul>').addClass('results'))
}
