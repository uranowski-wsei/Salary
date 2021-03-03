using System.Collections.Generic;

namespace Salary_Distribution.Models
{
    public class SalariesModel
    {
        public WorkTime WorkingTime { get; set; }


        public enum WorkTime
        {
            Styczeń,
            Luty,
            Marzec,
            Kwiecień,
            Maj,
            Czerwiec,
            Lipiec,
            Sierpień,
            Wrzesień,
            Październik,
            Listopad,
            Grudzień

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
