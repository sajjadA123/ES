using System;
using MD.PersianDateTime.Core;

namespace ES.Common.Helpers
{
    public static class PersianDateHelper
    {
        /// <summary>
        /// نمونه زمان
        /// جمعه، 14 آذر 1393
        /// </summary>
        public static PersianDateTime StringToPersianDate(string date)
        {
            try
            {
                var pers = PersianDateTime.Parse(date);
                return pers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// نمونه زمان
        /// جمعه، 14 آذر 1393
        /// </summary>
        public static string ToFullPersianDate(this DateTime date)
        {
            try
            {
                if (date != null)
                {
                    var input = new PersianDateTime(date);
                    return input.ToLongDateString();
                }
                return " - ";
            }
            catch (Exception)
            {
                return " - ";
            }
        }

        /// <summary>
        /// نمونه زمان
        /// 1398
        /// </summary>
        public static int ToPersianYear(this DateTime date)
        {
            try
            {
                if (date != null)
                {
                    var input = new PersianDateTime(date);
                    return input.Year;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// نمونه زمان
        /// فروردین میشه 1
        /// </summary>
        public static int ToPersianMonthInt(this DateTime date)
        {
            try
            {
                if (date != null)
                {
                    var input = new PersianDateTime(date);
                    return input.Month;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// نمونه زمان
        /// فروردین میشه 1
        /// </summary>
        public static int ToPersianYearInt(this DateTime date)
        {
            try
            {
                if (date != null)
                {
                    var input = new PersianDateTime(date);
                    return input.Year;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// نمونه زمان
        /// فروردین
        /// </summary>
        public static string GetMonth(this DateTime date)
        {
            try
            {
                if (date != null)
                {
                    var input = new PersianDateTime(date);
                    return input.MonthName;
                }
                return " - ";
            }
            catch (Exception)
            {
                return " - ";
            }
        }

        /// <summary>
        /// نمونه زمان
        /// 1393/09/14
        /// </summary>
        public static string PersianDate(DateTime? date)
        {
            try
            {
                if (date != null)
                {
                    var input = new PersianDateTime(date);
                    return input.ToShortDateString();
                }
                return " - ";
            }
            catch (Exception)
            {
                return "-";
            }
        }

        /// <summary>
        /// نمونه زمان
        /// فرمت اصلی
        /// </summary>
        public static PersianDateTime? PersianDateDefaultFormat(DateTime date)
        {
            try
            {
                if (date != null)
                {
                    return new PersianDateTime(date);
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// نمونه زمان
        /// تبدیل int به زمان
        /// </summary>
        public static PersianDateTime IntToDateTime(long number)
        {
            try
            {
                string sNum = number.ToString();
                int year = Convert.ToInt32(sNum.Substring(0, 4));
                int month = Convert.ToInt32(sNum.Substring(4, 2));
                int day = Convert.ToInt32(sNum.Substring(6, 2));

                if (month > 12 || day > 31)
                {
                    throw new Exception("formatDate");
                }

                return new PersianDateTime(year, month, day);

            }
            catch (Exception)
            {
                throw new Exception("formatDate");
            }
        }


        /// <summary>
        /// نمونه زمان
        /// 01:47:40 ب.ظ 
        /// </summary>
        public static string PersianTime(DateTime? date)
        {
            try
            {
                if (date != null)
                {
                    var input = new PersianDateTime(date);
                    return input.ShortTimeOfDay;
                }
                return " - ";
            }
            catch (Exception)
            {
                return "-";
            }
        }
    }
}
