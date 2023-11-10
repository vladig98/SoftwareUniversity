async function attachEvents() {
    $('#btnLoadPosts').on('click', function () {
        let promise = fetch('https://baas.kinvey.com/appdata/kid_ryIhE3q7p/Posts', {
            headers: new Headers({
                'Authorization': 'Basic ' + btoa('guest:guest')
            })
        }).then(handleResponse).then(processData).catch(handleError);
    })

    $('#btnViewPost').on('click', function () {
        let selectedOptionId = $('#posts').find(":selected").val();
        let promise = fetch('https://baas.kinvey.com/appdata/kid_ryIhE3q7p/Posts/' + selectedOptionId, {
            headers: new Headers({
                'Authorization': 'Basic ' + btoa('guest:guest')
            })
        }).then(handleResponse).then(data => processPost(data, selectedOptionId)).then(handleResponse).then(processComments).catch(handleError);
    })
}

function processComments(data) {
    $('#post-comments').empty();
    for (let o of data) {
        $('#post-comments').append(`<li>${o.text}</li>`)
    }
}

function processPost(data, selected) {
    $('#post-title').text(data.title)
    $('#post-body').text(data.body)

    return fetch(`https://baas.kinvey.com/appdata/kid_ryIhE3q7p/comments/?query={"post_id":"${selected}"}`, {
        headers: new Headers({
            'Authorization': 'Basic ' + btoa('guest:guest')
        })
    })
}

function handleResponse(response) {
    return response.json()
}

function processData(data) {
    for (let d of data) {
        $('#posts').append(`<option value='${d._id}'>${d.title}</option>`)
    }
}

function handleError(err) {
    $('#post-comments').text(err.message)
}