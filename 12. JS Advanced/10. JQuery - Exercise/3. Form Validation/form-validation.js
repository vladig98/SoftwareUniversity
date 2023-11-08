function validate() {
	$('button#submit').on('click', function (e) {
		e.preventDefault()

		if (!/[a-zA-Z0-9]{3,20}/g.test($('input#username').val())) {
			$('input#username').css('border-color', 'red');
		}
		else {
			$('input#username').css('border-color', '');
		}

		if ($('input#password').val() != $('input#confirm-password').val()) {
			$('input#password').css('border-color', 'red');
			$('input#confirm-password').css('border-color', 'red');
		}
		else {
			$('input#password').css('border-color', '');
			$('input#confirm-password').css('border-color', '');
		}

		if (!/.{5,15}/g.test($('input#password').val())) {
			$('input#password').css('border-color', 'red');
		}
		else {
			$('input#password').css('border-color', '');
		}

		if (!/.{5,15}/g.test($('input#confirm-password').val())) {
			$('input#confirm-password').css('border-color', 'red');
		}
		else {
			$('input#confirm-password').css('border-color', '');
		}

		if (!/.*@.*\..*/g.test($('input#email').val())) {
			$('input#email').css('border-color', 'red');
		}
		else {
			$('input#email').css('border-color', '');
		}

		if (!$('fieldset#companyInfo').is(':hidden')) {
			if (Number($('input#companyNumber').val()) < 1000 || Number($('input#companyNumber').val()) > 9999) {
				$('input#companyNumber').css('border-color', 'red');
			}
			else {
				$('input#companyNumber').css('border-color', '');
			}
		}

		if ($('input[style*="border-color: red"]').length > 0) {
			$('div#valid').css('display', 'none');
		}
		else {
			$('div#valid').css('display', '');
		}
	})

	$('input#company').on('change', function (e) {
		if (e.currentTarget.checked) {
			$('fieldset#companyInfo').css('display', '');
		}
		else {
			$('fieldset#companyInfo').css('display', 'none');
			$('input#companyNumber').css('border-color', '');
		}
	})
}
