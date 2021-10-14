using System;

namespace BL.Model
{
    /// <summary>
    /// Model of exercise
    /// take kind of activity, activity duration, and user who do exercise
    /// </summary>
    [Serializable]
    public class Exercise
    {

        public double Duration { get; }
        public Activity Activity { get; }
        public Exercise(Activity activity, double duration)
        {
            if (duration < 0)
            {
                throw new ArgumentNullException("duration of exercise cant be less than 0");
            }
            Activity = activity ?? throw new ArgumentNullException("Activity cant be null", nameof(activity));
            Duration = duration;
        }

    }
}
