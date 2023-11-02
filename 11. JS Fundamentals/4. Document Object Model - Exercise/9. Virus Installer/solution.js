function solve() {
    let content = document.getElementById("content");
    let firstStep = document.getElementById("firstStep");
    let secondStep = document.getElementById("secondStep");
    let thirdStep = document.getElementById("thirdStep");

    let next = document.getElementsByTagName("button")[0];
    let cancel = document.getElementsByTagName("button")[1];

    let license = document.getElementsByName("license");

    next.addEventListener("click", function() {
        if (firstStep.style.display == "" && secondStep.style.display == "" && thirdStep.style.display == "") {
            content.style.backgroundImage = "url('')";
            firstStep.style.display = "block";
        }
        else if (secondStep.style.display == "" && thirdStep.style.display == "") {
            if ([...license].filter(function(x) { return x.checked }).length > 0) {
                if ([...license].filter(function(x) { return x.checked })[0].value == "agree") {
                    firstStep.style.display = "";
                    secondStep.style.display = "block";
                    next.style.display = "none";

                    setTimeout(function() {
                        next.style.display = "";
                    }, 3000);
                }
            }
        }
        else {
            secondStep.style.display = "";
            thirdStep.style.display = "block";
            next.style.display = "none";
            cancel.innerHTML = "Finish";
        }
    });

    cancel.addEventListener("click", function() {
        document.getElementsByTagName("section")[0].style.display = "none";
    });
}