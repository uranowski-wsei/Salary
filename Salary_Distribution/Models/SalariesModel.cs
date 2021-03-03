using System.Collections.Generic;

namespace Salary_Distribution.Models
{
    public class SalariesModel
    {
        public WorkTime WorkingTime { get; set; }

        public enum WorkTime
        {
            Styczen,
            Luty,
            Marzec,
            Kwiecien,
            Maj,
            Czerwiec,
            Lipiec,
            Sierpien,
            Wrzesien,
            Pazdziernik,
            Listopad,
            Grudzien
        }
    }

}