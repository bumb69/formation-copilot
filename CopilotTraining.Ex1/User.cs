using System;

namespace CopilotTraining.Ex1
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        // <summary>
        // Validates the user object.
        // </summary>
        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
                return false;
            if (string.IsNullOrWhiteSpace(LastName))
                return false;
            return Age >= 0;
        }
    }
}
