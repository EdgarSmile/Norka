using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Norka.Common
{
  public static class Extensions
  {
    /// <summary>
    /// Converts to friendly date string.
    /// </summary>
    /// <param name="dateTime">The date time.</param>
    /// <returns></returns>
    public static string ToFriendlyDateString(this DateTime dateTime)
    {
      var dateString = string.Empty;
      if (dateTime.Date == DateTime.Today)
      {
        dateString = "Heute";
      }
      else if (dateTime.Date == DateTime.Today.AddDays(-1))
      {
        dateString = "Gestern";
      }
      else
      {
        dateString = dateTime.ToShortDateString();
      }
      return dateString += ",  " + dateTime.ToShortTimeString() + " Uhr";
    }
  }
}
