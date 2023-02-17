using TestQuizz.Models;

namespace TestQuizz.Domain
{
    public interface IQuizzRepository
    {
        PassageViewModel GetPassageData(int quizzId, int? questionId);
    }
}