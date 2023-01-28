using System;

public class Demo {
   public static void Main() {
      DayOfWeek wk = DateTime.Today.DayOfWeek;
      Console.WriteLine(wk);
      string _currentDate = DateTime.UtcNow.ToString("dddd, dd MMMM, yyyy");
      Console.WriteLine ($"Today is, {_currentDate}");
   }
}