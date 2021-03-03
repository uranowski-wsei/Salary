(function () {
  const employeesTable = document.getElementById("employeesTable");
  const hoursPlace = document.getElementById("hoursPlace");
  const inputMoney = document.getElementById("inputMoney");
  const update = document.getElementById("update");
  const send = document.getElementById("send");
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

  let canSend = false;

  const changeSalaryPlan = async () => {
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
      budget = 0;
      inputMoney.value = "";

      await getSalaryPlan(workingTimeValue);

      await getEmployees();

      salariesPage.classList.add("loaded");
    } else {
      salariesPage.classList.remove("loaded");
    }
  }

  const getSalaryPlan = async (workingTimeValue) => {
    const response = await fetch("/api/salary/getPlan?workTime=" + workingTimeValue, {
        method: "GET",
        headers: {
            "Content-Type": "application/json;charset=utf-8"
        },
    });
  
    const responseData = await response.json();

    if(responseData.budget > 0){
      budget = responseData.budget;
      inputMoney.value = budget;
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

          canSend = true;

          if(isNaN(budget)){
            if(inputMoney.value.length === 0){
              budget = total;
              canSend = false;
            } else {
              alert("Wprowadzona płaca ma niewłaściwy format!");
              canSend = false;
              return false;
            }
          } else {
            if(budget < total){
              alert("Budżet jest mniejszy niż minimalna płaca pracowników!");
              canSend = false;
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

  const saveSalaryPlan = async () => {
    const workingTimeValue = parseInt(workingTime.value);

    if(!canSend){
      alert("Budżet nie jest poprawnie wyznaczony!");
      return false;
    }

    const requestData = JSON.stringify({
        WorkTime: workingTimeValue,
        Budget: budget
    });

    const response = await fetch("/api/salary/savePlan", {
        method: "POST",
        headers: {
            "Content-Type": "application/json;charset=utf-8"
        },
        body: requestData
    });

    const responseJson = await response.json();
    alert(responseJson.message);
  }

  window.addEventListener("load", () => {
    workingTime.querySelectorAll("option").forEach((opt, i) => {
      if(i > 0){
        opt.value = i - 1;
      }
    })

    workingTime.addEventListener("change", () => {
      changeSalaryPlan();
    })

    update.addEventListener("click", () => {
      getEmployees();
    })

    send.addEventListener("click", () => {
      saveSalaryPlan();
    })
  });
})();