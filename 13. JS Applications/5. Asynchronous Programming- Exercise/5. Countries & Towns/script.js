function attachEvents() {
    const countryUrl = 'https://baas.kinvey.com/appdata/kid_ryIhE3q7p/countries';
    const townUrl = 'https://baas.kinvey.com/appdata/kid_ryIhE3q7p/towns';
    const username = 'guest';
    const password = 'guest';
    const token = btoa(`${username}:${password}`);
    const header = { "Authorization": `Basic ${token}` };

    $('#showBtn').on('click', showCountries);
    $('#createCountryBtn').on('click', createCountry);
    $('#createTownBtn').on('click', createTown);

    async function showCountries() {
        try {
            let countries = await $.ajax({
                method: 'GET',
                url: countryUrl,
                headers: header
            });

            $('#countries div').empty();
            appendCountries(countries);
        } catch (error) {
            console.log(error);
        }
    }

    async function createCountry() {
        await $.ajax({
            method: 'POST',
            url: countryUrl,
            headers: header,
            data: {
                name: $('#countryName').val()
            }
        });

        $('#countryName').val('');
        $('#countries div').empty();
        showCountries();
    }

    async function createTown() {
        let countries = await $.ajax({
            method: 'GET',
            url: countryUrl,
            headers: header
        });

        let country = countries.filter(c => c.name === $('#townCountryName').val())[0];
        if (country) {
            await $.ajax({
                method: 'POST',
                url: townUrl,
                headers: header,
                data: {
                    name: $('#townName').val(),
                    country: country._id
                }
            });

            $('#townSuccess').append('<h3>Town was created successfully!</h3>');
        } else {
            $('#townSuccess').append('<h3>Country does not exist!</h3>');
        }

        setTimeout(function () {
            $('#townSuccess').empty();
        }, 5000);

        $('#townCountryName').val('');
        $('#townName').val('')

        $('#countries div').empty();
        showCountries();
    }

    async function appendCountries(countries) {
        let $countries = $('#countries');
        for (let country of countries) {
            let $div = $('<div>').attr('country-id', country._id);
            $div.append(`<label style="font-weight: 900; margin-right: 10px">Country</label>`);
            $div.append(`<input type="text" id="countryUpdateName" name="${country._id}" value="${country.name}"/>`);

            let $updateBtn = $('<button>').attr('id', 'updateCountryBtn').text('Update Country');
            $updateBtn.css("margin", "10px")
            $updateBtn.on('click', async function () {
                updateContry(country._id);
            });
            $div.append($updateBtn);

            let $deleteBtn = $('<button>').attr('id', 'deleteCountryBtn').text('Delete Country');
            $deleteBtn.on('click', async function () {
                deleteCountry(country._id);
            });
            $div.append($deleteBtn);

            let $ul = $('<ul>')

            try {
                let townsInDb = await $.ajax({
                    method: 'GET',
                    url: townUrl,
                    headers: header
                });
                let towns = townsInDb.filter(t => t.country === country._id);
                for (let town of towns) {
                    let $li = $('<li>')
                    let $divTown = $('<div>')
                    $divTown.css("padding", "20px")
                    $divTown.append(`<label style="margin-right: 10px">Town</label>`);
                    $divTown.append(`<input type="text" id="townName" name="${town._id}" value="${town.name}"/>`);


                    let $updateBtnTwn = $('<button>').attr('id', 'updateTownBtn').text('Update Town');
                    $updateBtnTwn.css("margin", "10px").css("background-color", "black")
                    $updateBtnTwn.on('click', async function () {
                        updateTown(town._id, country._id);
                    });
                    $divTown.append($updateBtnTwn);

                    let $deleteBtnTwn = $('<button>').attr('id', 'deleteTownBtn').text('Delete Town');
                    $deleteBtnTwn.css("background-color", "black")
                    $deleteBtnTwn.on('click', async function () {
                        deleteTown(town._id);
                    });
                    $divTown.append($deleteBtnTwn);

                    $li.append($divTown);
                    $ul.append($li)
                }

                $div.append($ul);
            } catch (error) {
                console.log(error);
            }

            $countries.append($div);
        }
    }

    async function updateTown(townId, countryId) {
        await $.ajax({
            method: 'PUT',
            url: `${townUrl}/${townId}`,
            headers: header,
            data: {
                name: $(`input[name="${townId}"]`).val(),
                country: countryId
            }
        });

        $('#countries div').empty();
        showCountries();
    }

    async function deleteTown(townId) {
        await $.ajax({
            method: 'DELETE',
            url: `${townUrl}/${townId}`,
            headers: header,
        });

        $('#countries div').empty();
        showCountries();
    }

    async function updateContry(countryId) {
        await $.ajax({
            method: 'PUT',
            url: `${countryUrl}/${countryId}`,
            headers: header,
            data: {
                name: $(`input[name="${countryId}"]`).val()
            }
        });

        $('#countries div').empty();
        showCountries();
    }

    async function deleteCountry(countryId) {
        await $.ajax({
            method: 'DELETE',
            url: `${countryUrl}/${countryId}`,
            headers: header,
        });

        await $.ajax({
            method: 'DELETE',
            url: `${townUrl}/?query={"country":"${countryId}"}`,
            headers: header,
        });

        $('#countries div').empty();
        showCountries();
    }
}