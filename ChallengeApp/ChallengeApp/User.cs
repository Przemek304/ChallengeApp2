

namespace ChallengeApp
{
    public class User
    {
        List<int> score = new List<int>();
        public User(string name, string surename, int age)
        {
            this.Name = name;
            this.SureName = name;
            this.Age = age;

        }
        public string Name { get; private set; }
        public string SureName { get; private set; }

        public int Age { get; private set; }
        


        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }
}


