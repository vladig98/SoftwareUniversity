function getInfo() {
    $("#buses").text('')
    $("#stopName").text('')

    let stopid = $('#stopId').val()
    $('#stopId').val('')
    const baseUrl = `https://judgetests.firebaseio.com/businfo/`;

    $.ajax({
        url: baseUrl + stopid + '.json',
        method: 'GET',
        success: processResponse,
        error: displayError
    })

    function processResponse(response) {
        $("#stopName").text(response.name)

        for (let [key, value] of Object.entries(response.buses)) {
            $("#buses").append(`<li>Bus ${key} arrives in ${value} minutes</li>`);
        }
    }

    function displayError(err) {
        $("#stopName").text($('Error'))
    }
}