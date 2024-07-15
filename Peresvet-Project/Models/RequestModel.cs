namespace Peresvet_Project.Models
{
    public class RequestModel
    {
        public string Address { get; set; }
        public string RequiredSystems { get; set; }
        public string FunctionalPurpose { get; set; }
        public string ProjectAvailability { get; set; } // Наличие проектов на системы
        public string ProjectTimeline { get; set; } // Сроки реализации проекта
        public string CustomerContacts { get; set; }
        public string BuildingCharacteristics { get; set; }
        public string BuildingCondition { get; set; }
        public double CeilingHeight { get; set; }
        public double BuildingArea { get; set; }
        public int NumberOfFloors { get; set; }
        public string WorkSchedule { get; set; }
        public string ProjectDeveloper { get; set; }
        public string OldSystemInfo { get; set; }
        public IFormFile LayoutFile { get; set; }
        public string TechnicalSpecification { get; set; }
    }
}
