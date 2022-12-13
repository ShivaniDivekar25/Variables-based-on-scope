namespace Variable_Instance1
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Instance marks = new Instance();
            marks.engMarks = 90;
            marks.mathsMarks = 80;
            marks.phyMarks = 93;
            marks.MarksDetails();

            Instance marks1 = new Instance();
            marks1.engMarks = 95;
            marks1.mathsMarks = 70;
            marks1.phyMarks = 97;
            marks1.MarksDetails();
        }
    }
}