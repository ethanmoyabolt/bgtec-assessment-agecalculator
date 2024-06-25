using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgeCalculator
{
    public class CalculateAgeFunction
    {
        public string AgeCalculator(string date1)
        {
            AgeModel age = new AgeModel();
            // First using the value inputted into the DatePicker, the TryParse function checks if the date is valid
            if (DateTime.TryParse(date1, out DateTime result))
            {
                DateTime dateOfBirth = result;

                // Then checks if the value inputted is before the current date
                if (DateTime.Today < dateOfBirth)
                {
                    return "Please enter a date before today";
                }

                else
                {
                    // The amount of years is calculated first by taking the different between the birth year and the current yeat.
                    int years = DateTime.Today.Year - dateOfBirth.Year;
                    int months = 0;
                    int days = 0;

                    // If the birth date was the current year different calculations have to be considered
                    if (DateTime.Now.Year == dateOfBirth.Year)
                    {
                        // The number of months is calculated the same way the number of years is calculated
                        months = DateTime.Today.Month - dateOfBirth.Month;

                        // This check is done as a month has to be taken away if the day of your birthday is before the current day
                        // The days will also have to be calculated differently
                        if (dateOfBirth.Day >= DateTime.Now.Day)
                        {
                            days = CalculateDays(dateOfBirth);
                            months--;
                        }
                        else
                        {
                            days = DateTime.Today.Day - dateOfBirth.Day;
                        }
                    }
                    else
                    {
                        // This check to calculate months is done to check the months carried over if the birthday month is more than the current month
                        if (dateOfBirth.Month <= DateTime.Today.Month)
                        {
                            months = DateTime.Today.Month - dateOfBirth.Month;
                        }
                        else
                        {
                            months = 12 - (Math.Abs(dateOfBirth.Month - DateTime.Today.Month));
                        }

                        days = Math.Abs(dateOfBirth.Day - DateTime.Today.Day);

                        if (dateOfBirth.Month >= DateTime.Now.Month)
                        {
                            years--;
                        }

                        if (dateOfBirth.Day >= DateTime.Now.Day)
                        {
                            days = CalculateDays(dateOfBirth);
                            months--;
                        }

                        if (months == 12)
                        {
                            months = 0;
                        }

                    }


                    age.Years = years;
                    age.Months = months;
                    age.Days = days;

                    // The hours minutes and seconds are taken from the time the function was ran.
                    age.Hours = DateTime.Now.Hour;
                    age.Minutes = DateTime.Now.Minute;
                    age.Seconds = DateTime.Now.Second;

                    age.AgeToString = $"{age.Years} years, {age.Months} Months, {age.Days} days, {age.Hours} hours, {age.Minutes} minutes, {age.Seconds} seconds";

                    return age.AgeToString;

                }

            }
            else
            {
                return "Please enter a valid date";
            }
        }

        private int CalculateDays(DateTime dateOfBirth)
        {
            // This function takes into account the days from the end of the month of your birth to the current day, this only account for days.
            int daysInMonth = DateTime.DaysInMonth(dateOfBirth.Year, dateOfBirth.Month);
            int daysFrom = DateTime.Today.Day + (daysInMonth - dateOfBirth.Day);

            return daysFrom;
        }
    }
}
