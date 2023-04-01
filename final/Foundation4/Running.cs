using System;

public class Running : Activity{
   /*
   Purpose
   Calculate running speed and pace, assemble summary and add to _summaryList
   Inputs
   String Containing Activity
   Outputs
   Summary of Activity including date, 
   activity name, 
   time spent in activity, 
   distance traveled, 
   speed, 
   pace (minutes per mile)
   */
   public override double CalculateDistance(double minutes, double stat){
      return stat;
      }

   public override double CalculateSpeed(double minutes, double stat){
      return (stat/minutes)*60;
      }
   public override double CalculatePace(double minutes, double stat){
      return minutes/stat;
      }

   public Running(string activityInfo) : base(activityInfo){
      }
   }