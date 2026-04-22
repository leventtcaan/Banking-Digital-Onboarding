namespace Banking_Digital_Onboarding.Models
{
    public static class Repository
    {
        private static List<CustomerApplication> _applications = new List<CustomerApplication>();

        public static IEnumerable<CustomerApplication> Applications => _applications;

        public static void AddApplication(CustomerApplication application)
        {
            application.Id = _applications.Count + 1;
            _applications.Add(application);
        }
    }
}