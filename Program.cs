namespace lecture2_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }
    }


    public class Jobseeker
    {
        public string Name;
        public string LastName;

        public List<WorkExperienceItem> WorkExperienceItems;

        public int GetTotalExperience()
        {
            int total = 0;

            foreach (var item in WorkExperienceItems)
            {
                total += item.GetExperience();
            }

            return total;
        }

        public int GetExperience(int minimumExperience=0)
        {
            int total = 0;

            foreach (var item in WorkExperienceItems)
            {
                var tempExperience = item.GetExperience();
                if (tempExperience > minimumExperience)
                {
                    total += item.GetExperience();
                }
            }

            return total;
        }

        public int GetExperienceByCategry(int minimumExperience, Category category)
        {
            int total = 0;

            foreach (var item in WorkExperienceItems)
            {
                var tempExperience = item.GetExperience();
                if (tempExperience > minimumExperience && item.Category == category)
                {
                    total += item.GetExperience();
                }
            }

            return total;
        }
    }

    public class WorkExperienceItem
    {
        public string Position;
        public string Company;

        public int StartYear;
        public int EndYear;

        public Category Category;

        public int GetExperience()
        {
            return EndYear - StartYear;
        }

    }

    public enum Category
    {
        IT,
        Finances
    }


}