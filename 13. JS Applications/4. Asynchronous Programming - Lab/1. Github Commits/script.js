function loadCommits() {
    let URL = `https://api.github.com/repos/${$('#username').val()}/${$('#repo').val()}/commits`

    let promise = fetch(URL);

    promise.then(success).catch(error);
}

function success(data) {
    if (!data.ok) {
        throw new Error(`Error: ${data.status} (${data.statusText})`)
    }

    data.json().then(processResponse)
}

function error(err) {
    $('#commits').append(`<li>err.message</li>`)
}

function processResponse(data) {
    for (let d of data) {
        $('#commits').append(`<li>${d.commit.author.name}: ${d.commit.message}</li>`);
    }
}