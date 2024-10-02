namespace CompanyApp.Models
{
    public class Company
    {
        public string Name { get; set; }         // Назва компанії
        public string Address { get; set; }      // Адреса компанії
        public int EmployeeCount { get; set; }   // Кількість співробітників
        public string Industry { get; set; }     // Галузь компанії
    }
}
