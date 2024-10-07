namespace GeographicObjects
{
    public class River : GeographicObject
    {
        public decimal FlowSpeed { get; set; } // см/с
        public decimal TotalLength { get; set; } // загальна довжина

        public override string GetInfo()
        {
            return base.GetInfo() + $", Швидкість течії: {FlowSpeed} см/с, Загальна довжина: {TotalLength} км";
        }
    }
}
