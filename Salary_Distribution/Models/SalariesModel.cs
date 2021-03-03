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

            //Jan = 152,
            //Feb = 160,
            //Mar = 184,
            //Apr = 168,
            //May = 152,
            //Jun = 168,
            //Jul = 176,
            //Aug = 176,
            //Sep = 176,
            //Oct = 168,
            //Nov = 160,
            //Dec = 176
        }
    }

}