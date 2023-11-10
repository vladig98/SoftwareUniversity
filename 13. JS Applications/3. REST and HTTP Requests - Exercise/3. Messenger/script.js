function attachEvents() {
    let URL = 'https://messenger-8803f-default-rtdb.europe-west1.firebasedatabase.app/messenger'

    $('#submit').on("click", function (e) {
        e.preventDefault()

        let author = $('#author').val()
        let content = $("#content").val()

        $.ajax({
            url: URL + ".json",
            method: 'POST',
            data: JSON.stringify({
                author: author,
                content: content,
                timestamp: Date.now()
            })
        })
    })

    $('#refresh').on('click', function (e) {
        e.preventDefault()
        $('#messages').val('');

        $.ajax({
            url: URL + '.json',
            method: 'GET',
            success: function (data) {
                let result = [];
                for (let [key, value] of Object.entries(data)) {
                    result.push(value)
                }

                result.sort((a, b) => a.timestamp - b.timestamp)

                $('#messages').val(result.map(x => `${x.author}: ${x.content}`).join("\n"))
            }
        })
    })
}