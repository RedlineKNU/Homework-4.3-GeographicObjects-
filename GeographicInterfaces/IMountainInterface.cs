using GeographicInterfaces;
namespace Homework_4._3.GeographicInterfaces
{
    public class Mountain : IGeographicObject
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public string Name { get; set; } = string.Empty; // Ініціалізація для уникнення null
        public string Description { get; set; } = string.Empty; // Ініціалізація для уникнення null

        public decimal HighestPoint { get; set; } // м

        public string GetInfo()
        {
            return $"Назва: {Name}, Опис: {Description}, Координати: ({X}, {Y}), Найвища точка: {HighestPoint} м";
        }
    }
}
