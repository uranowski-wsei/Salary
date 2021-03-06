﻿(function () {
    const formElement = document.getElementById("employeeForm");
    const employeesTable = document.getElementById("employeesTable");

    const addNewEmployee = async () => {
        const requestData = JSON.stringify({
            Name: document.getElementById("userName").value,
            Surname: document.getElementById("userSurname").value,
            Foreman: document.getElementById("isForeman").checked,
            Salary: parseInt(document.getElementById("salary").value)
        });

        const response = await fetch("/api/employees/add", {
            method: "POST",
            headers: {
                "Content-Type": "application/json;charset=utf-8"
            },
            body: requestData
        });
        const responseJson = await response.json();
    };

    const getEmployees = async () => {
        const response = await fetch("/api/employees/get", {
            method: "GET"
        });

        const responseData = await response.json();
        
        if(responseData){
            employeesTable.innerHTML = "";
            responseData.forEach(row => {
                const tableRow = `
                    <tr>
                        <td>
                            ${row.name}
                        </td>
                        <td>
                            ${row.surname}
                        <td>
                            ${row.foreman ? "Tak" : "Nie"}
                        </td>
                        <td>
                            ${row.salary}
                        </td>
                    </tr>
                `;

                employeesTable.insertAdjacentHTML("beforeend", tableRow);
            })
        }
    }

    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewEmployee()
                .then(() => {
                    alert("Dodano pracownika!");

                    getEmployees();
                })
                .catch((err) => {
                    console.log(err);
                });
        });
    });
})();