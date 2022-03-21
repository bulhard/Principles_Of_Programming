using Lesson_05_Principles_OOP.Inheritance;

namespace Lesson_05_Principles_OOP.Abstraction
{
    public interface IReproducible<T> where T : Felidae
    {
        T[] Reproduce(T mate);
    }
}