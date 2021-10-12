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
        /// <summary>
        /// Duration of exercise
        /// </summary>
        public double Duration { get; }
        /// <summary>
        /// kind of activity
        /// </summary>
        public Activity Activity { get; }
        /// <summary>
        /// User, who do exercise
        /// </summary>
        public User User { get; }
        /// <summary>
        /// constraction
        /// </summary>
        /// <param name="activity">kind of activity</param>
        /// <param name="duration">duration of exercise</param>
        /// <param name="user">user who do exercise</param>
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
