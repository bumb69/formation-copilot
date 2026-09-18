using System;

namespace CopilotTraining.Ex1
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        // <summary>
        // Valide le user
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
