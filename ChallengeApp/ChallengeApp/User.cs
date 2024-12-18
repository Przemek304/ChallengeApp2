
namespace ChallengeApp
{
    public class User
    {
        List<float> grades = new List<float>();
        public User(string name, string surename)
        {
            this.Name = name;
            this.Surename = surename;
        }


        public string Name { get; private set; }
        public string Surename { get; private set; }

        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);   
        }

    }
}
