namespace Gragebook
{
    public interface IBook
    {
        void AddGrade(double grade);

        Statistics GetStatistics();

        string Name { get; }

        event GradeAddedDelegate GradeAdded;

        abstract void DeleteFileAfterWork();
    }
}