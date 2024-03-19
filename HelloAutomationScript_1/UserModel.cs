namespace HelloAutomationScript_1
{
    using System;

    public class UserModel : IUserModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string CreditCardNumber { get; set; }

        public string ExpirationDateMonth { get; set; }

        public string ExpirationDateYear { get; set; }

        public string MotherMaidenName { get; set; }

        public string CVC { get; set; }

        public DateTime TimeSent { get; set; }
    }
}
