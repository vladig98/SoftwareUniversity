function attachEventsListeners() {
    let inputDistance = document.getElementById('inputDistance')
    let outputDistance = document.getElementById('outputDistance')
    let inputUnits = document.getElementById('inputUnits')
    let outputUnits = document.getElementById('outputUnits')
    let convert = document.getElementById('convert')

    convert.addEventListener("click", function () {
        let selectedUnitInput = [...inputUnits.children].filter(x => x.selected)[0]
        let selectedUnitOutput = [...outputUnits.children].filter(x => x.selected)[0]


        switch (selectedUnitInput.value) {
            case "km":
                let kmtom = Number(inputDistance.value) * 1000;
                switch (selectedUnitOutput.value) {
                    case "km":
                        outputDistance.value = inputDistance.value;
                        break;
                    case "m":
                        outputDistance.value = kmtom;
                        break;
                    case "cm":
                        outputDistance.value = kmtom / 0.01;
                        break;
                    case "mm":
                        outputDistance.value = kmtom / 0.001;
                        break;
                    case "mi":
                        outputDistance.value = kmtom / 1609.34;
                        break;
                    case "yrd":
                        outputDistance.value = kmtom / 0.9144;
                        break;
                    case "ft":
                        outputDistance.value = kmtom / 0.3048;
                        break;
                    case "in":
                        outputDistance.value = kmtom / 0.0254;
                        break;
                    default:
                        break;
                }
                break;
            case "m":
                switch (selectedUnitOutput.value) {
                    case "km":
                        outputDistance.value = Number(inputDistance.value) / 1000;
                        break;
                    case "m":
                        outputDistance.value = inputDistance.value;
                        break;
                    case "cm":
                        outputDistance.value = Number(inputDistance.value) / 0.01;
                        break;
                    case "mm":
                        outputDistance.value = Number(inputDistance.value) / 0.001;
                        break;
                    case "mi":
                        outputDistance.value = Number(inputDistance.value) / 1609.34;
                        break;
                    case "yrd":
                        outputDistance.value = Number(inputDistance.value) / 0.9144;
                        break;
                    case "ft":
                        outputDistance.value = Number(inputDistance.value) / 0.3048;
                        break;
                    case "in":
                        outputDistance.value = Number(inputDistance.value) / 0.0254;
                        break;
                    default:
                        break;
                }
                break;
            case "cm":
                let mtocm = Number(inputDistance.value) * 0.01;
                switch (selectedUnitOutput.value) {
                    case "km":
                        outputDistance.value = mtocm / 1000;
                        break;
                    case "m":
                        outputDistance.value = mtocm;
                        break;
                    case "cm":
                        outputDistance.value = inputDistance.value;
                        break;
                    case "mm":
                        outputDistance.value = mtocm / 0.001;
                        break;
                    case "mi":
                        outputDistance.value = mtocm / 1609.34;
                        break;
                    case "yrd":
                        outputDistance.value = mtocm / 0.9144;
                        break;
                    case "ft":
                        outputDistance.value = mtocm / 0.3048;
                        break;
                    case "in":
                        outputDistance.value = mtocm / 0.0254;
                        break;
                    default:
                        break;
                }
                break;
            case "mm":
                let mmtom = Number(inputDistance.value) * 0.001;
                switch (selectedUnitOutput.value) {
                    case "km":
                        outputDistance.value = mmtom / 1000;
                        break;
                    case "m":
                        outputDistance.value = mmtom;
                        break;
                    case "cm":
                        outputDistance.value = mmtom * 0.01;
                        break;
                    case "mm":
                        outputDistance.value = inputDistance.value;
                        break;
                    case "mi":
                        outputDistance.value = mmtom / 1609.34;
                        break;
                    case "yrd":
                        outputDistance.value = mmtom / 0.9144;
                        break;
                    case "ft":
                        outputDistance.value = mmtom / 0.3048;
                        break;
                    case "in":
                        outputDistance.value = mmtom / 0.0254;
                        break;
                    default:
                        break;
                }
                break;
            case "mi":
                let mitom = Number(inputDistance.value) * 1609.34;
                switch (selectedUnitOutput.value) {
                    case "km":
                        outputDistance.value = mitom / 1000;
                        break;
                    case "m":
                        outputDistance.value = mitom;
                        break;
                    case "cm":
                        outputDistance.value = mitom * 0.01;
                        break;
                    case "mm":
                        outputDistance.value = mitom / 0.001;
                        break;
                    case "mi":
                        outputDistance.value = inputDistance.value
                        break;
                    case "yrd":
                        outputDistance.value = mitom / 0.9144;
                        break;
                    case "ft":
                        outputDistance.value = mitom / 0.3048;
                        break;
                    case "in":
                        outputDistance.value = mitom / 0.0254;
                        break;
                    default:
                        break;
                }
                break;
            case "yrd":
                let yrdtom = Number(inputDistance.value) * 0.9144;
                switch (selectedUnitOutput.value) {
                    case "km":
                        outputDistance.value = yrdtom / 1000;
                        break;
                    case "m":
                        outputDistance.value = yrdtom;
                        break;
                    case "cm":
                        outputDistance.value = yrdtom * 0.01;
                        break;
                    case "mm":
                        outputDistance.value = yrdtom / 0.001;
                        break;
                    case "mi":
                        outputDistance.value = yrdtom / 1609.34;
                        break;
                    case "yrd":
                        outputDistance.value = inputDistance.value
                        break;
                    case "ft":
                        outputDistance.value = yrdtom / 0.3048;
                        break;
                    case "in":
                        outputDistance.value = yrdtom / 0.0254;
                        break;
                    default:
                        break;
                }
                break;
            case "ft":
                let fttom = Number(inputDistance.value) * 0.3048;
                switch (selectedUnitOutput.value) {
                    case "km":
                        outputDistance.value = fttom / 1000;
                        break;
                    case "m":
                        outputDistance.value = fttom;
                        break;
                    case "cm":
                        outputDistance.value = fttom * 0.01;
                        break;
                    case "mm":
                        outputDistance.value = fttom / 0.001;
                        break;
                    case "mi":
                        outputDistance.value = fttom / 1609.34;
                        break;
                    case "yrd":
                        outputDistance.value = fttom / 0.9144;
                        break;
                    case "ft":
                        outputDistance.value = inputDistance.value
                        break;
                    case "in":
                        outputDistance.value = fttom / 0.0254;
                        break;
                    default:
                        break;
                }
                break;
            case "in":
                let intom = Number(inputDistance.value) * 0.0254;
                switch (selectedUnitOutput.value) {
                    case "km":
                        outputDistance.value = intom / 1000;
                        break;
                    case "m":
                        outputDistance.value = intom;
                        break;
                    case "cm":
                        outputDistance.value = intom * 0.01;
                        break;
                    case "mm":
                        outputDistance.value = intom / 0.001;
                        break;
                    case "mi":
                        outputDistance.value = intom / 1609.34;
                        break;
                    case "yrd":
                        outputDistance.value = intom / 0.9144;
                        break;
                    case "ft":
                        outputDistance.value = intom / 0.3048;
                        break;
                    case "in":
                        outputDistance.value = inputDistance.value
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }

    })
}