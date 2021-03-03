(function () {
  const employeesTable = document.getElementById("employeesTable");
  const hoursPlace = document.getElementById("hoursPlace");
  const inputMoney = document.getElementById("inputMoney");
  const update = document.getElementById("update");
  const salariesPage = document.getElementById("salariesPage");

  const baseSumElement = document.getElementById("baseSum");
  const bonusSumElement = document.getElementById("bonusSum");
  const totalSumElement = document.getElementById("totalSum");
  
  const workingTime = document.getElementById("WorkingTime");

  let budget = 0;
  let currentWorkingTime = 0;
  let allBaseSalariesTotal = 0;
  let allBonusSalariesTotal = 0;
  let salariesTotal = 0;

  const updateWorkingTime = async () => {
    const workingTimeValue = parseInt(workingTime.value);

    if(!isNaN(workingTimeValue)){
      const response = await fetch("/api/salary/getWorkingTime?workTime=" + workingTimeValue, {
          method: "GET",
          headers: {
              "Content-Type": "application/json;charset=utf-8"
          },
      });
  
      const responseData = await response.json();

      currentWorkingTime = responseData.workingTime;
      hoursPlace.innerText = "W danym miesiącu jest " + currentWorkingTime + " godzin roboczych.";

      allBaseSalariesTotal = 0;
      allBonusSalariesTotal = 0;
      salariesTotal = 0;

      await getEmployees();

      salariesPage.classList.add("loaded");
    } else {
      salariesPage.classList.remove("loaded");
    }
  }

  const getEmployees = async () => {
      const response = await fetch("/api/employees/get", {
          method: "GET"
      });

      const responseData = await response.json();
      
      if(responseData){
          let total = 0;
          responseData.forEach(row => {
            total += row.salary * currentWorkingTime;
          })

          budget = parseInt(inputMoney.value);

          if(isNaN(budget)){
            if(inputMoney.value.length === 0){
              budget = total;
            } else {
              alert("Wprowadzona płaca ma niewłaściwy format!");
              return false;
            }
          } else {
            if(budget < total){
              alert("Budżet jest mniejszy niż minimalna płaca pracowników!");
              return false;
            }
          }

          const bonusPerEmployee = parseInt( Math.floor( ((budget - total) / responseData.length) ).toFixed(0) );

          allBaseSalariesTotal = 0;
          allBonusSalariesTotal = 0;
          salariesTotal = 0;

          employeesTable.innerHTML = "";

          responseData.forEach(row => {
              const baseSalary = row.salary * currentWorkingTime;
              const bonusSalary = bonusPerEmployee;
              const totalSalary = baseSalary + bonusSalary;

              allBaseSalariesTotal += baseSalary;
              allBonusSalariesTotal += bonusSalary;
              salariesTotal += totalSalary;

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
                      <td>
                          ${baseSalary}
                      </td>
                      <td>
                          ${bonusSalary}
                      </td>
                      <td>
                          ${totalSalary}
                      </td>
                  </tr>
              `;

              employeesTable.insertAdjacentHTML("beforeend", tableRow);
          })

          baseSumElement.innerText = allBaseSalariesTotal;
          bonusSumElement.innerText = allBonusSalariesTotal;
          totalSumElement.innerText = salariesTotal;
      }
  }

  window.addEventListener("load", () => {
    workingTime.querySelectorAll("option").forEach((opt, i) => {
      if(i > 0){
        opt.value = i - 1;
      }
    })

    workingTime.addEventListener("change", () => {
      updateWorkingTime();
    })

    update.addEventListener("click", () => {
      getEmployees();
    })
  });
})();