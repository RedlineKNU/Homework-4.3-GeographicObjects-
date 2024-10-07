namespace GeographicObjects
{
    public class Mountain : GeographicObject
    {
        public decimal HighestPoint { get; set; } // Найвища точка

        public override string GetInfo()
        {
            return base.GetInfo() + $", Найвища точка: {HighestPoint} м";
        }
    }
}
