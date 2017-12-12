using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    public Student(string fn, string ln, int studentID, int[] scores)
    {
        firstName = fn;
        lastName = ln;
        id = studentID;
        testScores = scores;
    }

    public string Calculate()
    {
        string testGrade = "";
        int testScoreTotal = 0;
        double testScoreAverage = 0;
        for (int i = 0; i < testScores.Length; i++)
        {
            testScoreTotal += testScores[i];
        }
        testScoreAverage = Convert.ToDouble(testScoreTotal / testScores.Length);
        if (testScoreAverage >= 40)
        {
            testGrade = "D";
            if (testScoreAverage >= 55)
            {
                testGrade = "P";
                if (testScoreAverage >= 70)
                {
                    testGrade = "A";
                    if (testScoreAverage >= 80)
                    {
                        testGrade = "E";
                        if (testScoreAverage >= 90)
                        {
                            testGrade = "O";
                        }
                    }
                }
            }
        }
        else
        {
            testGrade = "T";
        }
        return testGrade;
    }
}

class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}