namespace HelloAutomationScript_1
{
    public class UserModel : IUserModel
    {
        public UserModel()
        {
            Name = string.Empty;
            Surname = string.Empty;
            CreditCardNumber = string.Empty;
            ExpirationDateMonth = string.Empty;
            ExpirationDateYear = string.Empty;
            MotherMaidenName = string.Empty;
            CVC = string.Empty;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string CreditCardNumber { get; set; }

        public string ExpirationDateMonth { get; set; }

        public string ExpirationDateYear { get; set; }

        public string CVC { get; set; }

        public string MotherMaidenName { get; set; }
    }
}
