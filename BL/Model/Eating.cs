using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Model
{
    /// <summary>
    /// one meal
    /// </summary>
    [Serializable]
    public class Eating
    {
        /// <summary>
        /// ration of this eating
        /// </summary>
        public List<Portion> Ration { get; private set; }
        public User User { get; }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="user">user, who ate</param>
        /// <param name="portion"> The portion they ate </param>
        public Eating(User user, Portion portion = null)
        {
            User = user ?? throw new ArgumentNullException("User can`t be null",nameof(user));
            if (!(portion is null))
            {
                Ration = new List<Portion>();
                Ration.Add(portion);
            }
            else
                Ration = new List<Portion>();
        }
       /// <summary>
       /// add portion to meal
       /// </summary>
       /// <param name="portion"></param>
        public void AddFood(Portion portion)
        {
            Ration.Add(portion);
        }
    }
}// TODO: comment everything
