namespace GeographicObjects
{
    public abstract class GeographicObject
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual string GetInfo()
        {
            return $"Об'єкт: {Name}, Опис: {Description}, Координати: ({X}, {Y})";
        }
    }
}
