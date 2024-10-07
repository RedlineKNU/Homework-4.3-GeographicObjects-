using GeographicInterfaces;
namespace Homework_4._3.GeographicInterfaces
{
    public class River : IGeographicObject
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public string Name { get; set; } = string.Empty; // Ініціалізація для уникнення null
        public string Description { get; set; } = string.Empty; // Ініціалізація для уникнення null

        public decimal FlowSpeed { get; set; } // см/с
        public decimal TotalLength { get; set; } // км

        public string GetInfo()
        {
            return $"Назва: {Name}, Опис: {Description}, Координати: ({X}, {Y}), Швидкість течії: {FlowSpeed} см/с, Загальна довжина: {TotalLength} км";
        }
    }
}
