function bugReporter() {
    let reports = [];
    let outputSelector;

    function createReportId() {
        return reports.length;
    }

    function updateHTML() {
        if (!outputSelector) {
            console.error("Output selector not set!");
            return;
        }

        const outputElement = document.querySelector(outputSelector);
        if (!outputElement) {
            console.error("Output element not found!");
            return;
        }

        outputElement.innerHTML = reports
            .map(
                report =>
                    `<div id="report_${report.ID}" class="report">
              <div class="body">
                <p>${report.description}</p>
              </div>
              <div class="title">
                <span class="author">Submitted by: ${report.author}</span>
                <span class="status">${report.status} | ${report.severity}</span>
              </div>
            </div>`
            )
            .join("");
    }

    function report(author, description, reproducible, severity) {
        const newReport = {
            ID: createReportId(),
            author,
            description,
            reproducible,
            severity,
            status: "Open"
        };

        reports.push(newReport);
        updateHTML();
    }

    function setStatus(id, newStatus) {
        const reportToUpdate = reports.find(report => report.ID === id);
        if (reportToUpdate) {
            reportToUpdate.status = newStatus;
            updateHTML();
        }
    }

    function remove(id) {
        reports = reports.filter(report => report.ID !== id);
        updateHTML();
    }

    function sort(method = "ID") {
        reports.sort((a, b) => {
            if (method === "severity") {
                return a.severity - b.severity;
            } else if (method === "author") {
                return a.author.localeCompare(b.author);
            } else {
                return a.ID - b.ID;
            }
        });
        updateHTML();
    }

    function output(selector) {
        outputSelector = selector;
        updateHTML();
    }

    return {
        report,
        setStatus,
        remove,
        sort,
        output
    };
}