using System;

namespace BL.Model
{
    [Serializable]
    public class Exercise
    {
        public double Duration { get; }
        public Activity Activity { get; }
        public User User { get; }
        public Exercise(Activity activity, double duration, User user)
        {
            if (duration < 0)
            {
                throw new ArgumentNullException("duration of exercise cant be less than 0");
            }
            Activity = activity ?? throw new ArgumentNullException("Activity cant be null", nameof(activity));
            User = user ?? throw new ArgumentNullException("User cant be null",nameof(user)) ;
            Duration = duration;
        }
         
    }
}
