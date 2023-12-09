namespace GymCrab333333333.Models
{
    using System;
    using System.Collections.Generic;

    public class CrabEntity
    {
        private List<string> passiveAggressiveMessages;
        private int passiveAggressiveLevel;

        public CrabEntity()
        {
            passiveAggressiveMessages = new List<string>
        {
            "You call that exercise?",
            "Maybe next time you'll break a sweat.",
            "Is that all you've got?",
            "I've seen turtles move faster than you.",
            "Don't strain yourself too much, lifting that pizza slice must be heavy for you.",
            "Well, that was underwhelming.",
            "How do you expect to pull female canines when you can't even pull yourself up."
        };

            passiveAggressiveLevel = 0; // Initial level
        }

        public void CalculatePassiveAggressiveLevel(List<DateTime> dates)
        {
            if (dates.Count != 7)
            {
                throw new ArgumentException("The list must contain 7 dates.");
            }

            // Calculate the time between dates and adjust passiveAggressiveLevel
            for (int i = 1; i < dates.Count; i++)
            {
                TimeSpan timeDifference = dates[i] - dates[i - 1];

                if (timeDifference.Days >= 7)
                {
                    passiveAggressiveLevel += 2;
                }
                else if (timeDifference.Days >= 3)
                {
                    passiveAggressiveLevel += 1;
                }
                else if (timeDifference.Days <= 1)
                {
                    passiveAggressiveLevel -= 1;
                }
            }
        }

        public string GetPassiveAggressiveMessage()
        {
            // Ensure passiveAggressiveLevel is within a certain range
            passiveAggressiveLevel = Math.Max(0, Math.Min(6, passiveAggressiveLevel));

            // Return a passive-aggressive message based on the level
            return passiveAggressiveMessages[passiveAggressiveLevel];
        }
    }
}
