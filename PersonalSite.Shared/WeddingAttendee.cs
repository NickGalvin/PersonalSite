using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PersonalSite.Shared
{
    public class WeddingAttendee
    {
        public string Name { get; set; }
        public MealType Meal { get; set; } = MealType.Appentizers;

        public string DietaryRestrictions { get; set; }

        public AttendenceStatus Status { get; set; }

        public enum AttendenceStatus
        {
            Accept,
            Decline
        }
    }
}
