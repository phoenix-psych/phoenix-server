namespace Web.Entity
{
    public class Slot : BaseEntity
    {
        public byte MinHour { get; set; }
        public byte MinMinute { get; set; }
        public byte MaxHour { get; set; }
        public byte MaxMinute { get; set; }
    }
}
