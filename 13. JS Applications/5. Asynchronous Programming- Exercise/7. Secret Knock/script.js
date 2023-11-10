async function performSecretKnock() {
    const kinveyBaseUrl = 'https://baas.kinvey.com/appdata/kid_BJXTsSi-e/knock';

    try {
        // Log in to Kinvey
        const loginResponse = await $.ajax({
            url: 'https://baas.kinvey.com/user/kid_BJXTsSi-e/login',
            type: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': 'Basic ' + btoa('kid_BJXTsSi-e:447b8e7046f048039d95610c1b039390')
            },
            data: JSON.stringify({ username: 'guest', password: 'guest' }),
            dataType: 'json'
        });

        console.log('Login response:', loginResponse);

        // Start the Secret Knock
        let nextMessage = 'Knock Knock.';
        let answer;
        do {
            const queryUrl = `${kinveyBaseUrl}?query=${encodeURIComponent(nextMessage)}`;
            const knockResponse = await $.ajax({
                url: queryUrl,
                type: 'GET',
                headers: {
                    'Content-Type': 'application/json',
                    'Authorization': 'Kinvey ' + loginResponse._kmd.authtoken
                },
                dataType: 'json'
            });

            answer = knockResponse.answer;
            nextMessage = knockResponse.message;

            $('#results').append(`<p>Answer: ${answer}</p>`);
            $('#results').append(`<p>Next Message: ${nextMessage}</p>`);

        } while (nextMessage);

        $('#results').append('<p>Secret Knock completed.</p>');
    } catch (error) {
        console.error('Error:', error);
    }
}