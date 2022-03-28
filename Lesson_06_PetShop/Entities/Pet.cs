using Lesson_06_PetShop.Enums;
using Lesson_06_PetShop.Interfaces;

namespace Lesson_06_PetShop.Entities
{
    public class Pet : Animal, IStock
    {
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string Name { get; set; }

        public AgeState AgeState
        {
            get {
                var percent = (Age / MaxAge) * 100;

                if (percent < 25)
                {
                    return AgeState.Young;
                }
                else if (percent < 60)
                {
                    return AgeState.MidAge;
                }
                return AgeState.Old;
            }
        }

        public override string ToString()
        {
            return $"{Name}, Kind {Kind}, Age {Age}, Price {Price} Quantity={Quantity}";
        }
    }
}
