namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10.Lib
{
    public class Client
    {
        public string AccountNumber { get; set; }  // Номер счёта (уникальный ключ)
        public string LastName { get; set; }        // Фамилия
        public string FirstName { get; set; }       // Имя
        public string MiddleName { get; set; }      // Отчество
        public string Address { get; set; }         // Адрес
        public string Phone { get; set; }           // Телефон

        public string FullName => $"{LastName} {FirstName} {MiddleName}".Trim();

        public override string ToString() => $"{AccountNumber} | {FullName} | {Phone}";
    }
}