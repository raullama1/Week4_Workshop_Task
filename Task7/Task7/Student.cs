namespace Task7
{
    public class Student
    {
        private int marks;

        public void SetMarks(int m)
        {
            if(m >= 0 && m <= 100) marks = m;
        }

        public int GetMarks() => marks;
    }
}