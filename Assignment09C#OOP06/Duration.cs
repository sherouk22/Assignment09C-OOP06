using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09C_OOP06
{
    public class Duration
    {
       

        public int Hours {  get; set; }
        
        public int Minutes { get; set; }

        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration()
        {

        }

        public override string ToString()
        {
            return $"hours: {Hours} ,minutes: {Minutes} ,seconds: {Seconds} ";

        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds/3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;

        }

        public override bool Equals(object? obj)
        {
            Duration duration = (Duration)obj;

            return Hours == duration.Hours && Minutes == duration.Minutes && Seconds == duration.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public static Duration operator + (Duration left , Duration right)
        {
            return new Duration
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds
            };
        }

        
         public static Duration operator + (Duration left ,int seconds)
        {
            return new Duration
            {
                Hours = left.Hours,
                Minutes = left.Minutes,
                Seconds = left.Seconds + seconds

            };
        }

        public static Duration operator +(int seconds, Duration right)
        {
            return new Duration
            {
                Hours = right.Hours,
                Minutes = right.Minutes,
                Seconds = right.Seconds + seconds

            };

        }

        public static Duration operator ++(Duration duration)
        {
            return new Duration 
            {
                Hours = duration.Hours,
                Minutes = duration.Minutes +1 ,
                Seconds = duration.Seconds
            };
        }

        public static Duration operator --(Duration duration)
        {
            return new Duration
            {
                Hours = duration.Hours,
                Minutes = duration.Minutes - 1,
                Seconds = duration.Seconds
            };
        }

        public static bool operator > (Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
                return left.Minutes > right.Minutes;
            else if (left.Minutes == right.Minutes)
                return left.Seconds > right.Seconds;
            else
                return right.Hours > left.Hours;


        }

        public static bool operator < (Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
                return left.Minutes < right.Minutes;
            else if (left.Minutes == right.Minutes)
                return left.Seconds < right.Seconds;
            else
                return right.Hours < left.Hours;


        }

        public static bool operator <=(Duration left, Duration right)
        {
            return !(left > right);
        }

        public static bool operator >=(Duration left, Duration right)
        {
            return !(left < right);
        }

        public static implicit operator bool(Duration duration)
        {
            return duration.Hours > 0 || duration.Minutes > 0 || duration.Seconds > 0;
        }

        public static implicit operator DateTime(Duration duration)
        {
            return new DateTime().AddHours(duration.Hours).AddMinutes(duration.Minutes).AddSeconds(duration.Seconds);
        }

    }
}
