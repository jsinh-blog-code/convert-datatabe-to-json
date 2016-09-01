namespace ComplexJson
{
    using Newtonsoft.Json;

    public class Employee
    {
        private string firstName;

        private string lastName;

        private int averageSalePerDay;

        private int totalSales;

        public Employee()
        {
            this.EmpDetails = new Details();
            this.Statistics = new Aggregates();
        }

        public int EmployeeId { get; set; }

        public string EmployeeCode { get; set; }

        public int ManagerId { get; set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
                this.EmpDetails.FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
                this.EmpDetails.LastName = value;
            }
        }

        public int AverageSalePerDay
        {
            get
            {
                return this.averageSalePerDay;
            }

            set
            {
                this.averageSalePerDay = value;
                this.Statistics.AverageSalePerDay = value;
            }
        }

        [JsonIgnore]
        public int TotalSales
        {
            get
            {
                return this.totalSales;
            }

            set
            {
                this.totalSales = value;
                this.Statistics.TotalSales = value;
            }
        }

        public Details EmpDetails { get; set; }
        public Aggregates Statistics { get; set; }
    }
}