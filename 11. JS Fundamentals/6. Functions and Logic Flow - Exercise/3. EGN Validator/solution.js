function validate() {
    let year = document.getElementById('year');
    let month = document.getElementById('month');
    let date = document.getElementById('date');
    let gender = document.getElementsByName('gender');
    let region = document.getElementById('region');
    let egn = document.getElementById('egn');
    let button = document.getElementsByTagName('button')[0];

    let weightPosition = [2, 4, 8, 5, 10, 9, 7, 3, 6];

    button.addEventListener("click", function() {
        let number = "";

        if (Number(year.value) < 1900 || Number(year.value) > 2100) {
            return;
        }

        if (Number(region.value) < 43 || Number(region.value) > 999) {
            return;
        }

        number += year.value.split("")[year.value.split("").length - 2];
        number += year.value.split("")[year.value.split("").length - 1];

        let months = month.children;

        let m = '';

        for (let i = 0; i < months.length; i++) {
            if (months[i].selected) {
                m = months[i].value;
            }
        }

        switch (m) {
            case "January":
                number += "01";
                break;
            case "February":
                number += "02";
                break;
            case "March":
                number += "03";
                break;
            case "April":
                number += "04";
                break;
            case "May":
                number += "05";
                break;
            case "June":
                number += "06";
                break;
            case "July":
                number += "07";
                break;
            case "August":
                number += "08";
                break;
            case "September":
                number += "09";
                break;
            case "October":
                number += "10";
                break;
            case "November":
                number += "11";
                break;
            case "December":
                number += "12";
                break;
            default:
                break;
        }

        number += date.value.length == 1 ? "0" + date.value : date.value;

        number += region.value.split("")[0];
        number += region.value.split("")[1];

        if ([...gender].filter(function(x) { return x.checked })[0].value == "Male") {
            number += 2;
        }
        else {
            number += 1;
        }

        let arr = number.split("");

        let sum = 0;

        for (let i = 0; i < arr.length; i++) {
            sum += Number(arr[i]) * weightPosition[i];
        }

        number += (sum % 11) % 10;

        egn.innerHTML = number;

        year.value = "";
        date.value = "";
        region.value = "";
        for (let i = 0; i < gender.length; i++) {
            gender[i].checked = false;
        }
        month.children[0].selected = true;
    });
}