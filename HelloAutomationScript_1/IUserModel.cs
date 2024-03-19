namespace HelloAutomationScript_1
{
    using System;

    public interface IUserModel
    {
        string Name { get; set; }

        string Surname { get; set; }

        string CreditCardNumber { get; set; }

        string ExpirationDateMonth { get; set; }

        string ExpirationDateYear { get; set; }

        string MotherMaidenName { get; set; }

        string CVC { get; set; }

        DateTime TimeSent { get; set; }
    }
}
