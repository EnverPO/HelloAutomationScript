
namespace HelloAutomationScript_1
{
    using System;
    using Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls.InterAppMessages.MyTable;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    public class UserPresenter
    {
        private readonly UserView view;
        private readonly IUserModel model;

        public UserPresenter(UserView view, UserModel model)
        {
            this.view = view ?? throw new ArgumentNullException("View cannot be null.");
            this.model = model ?? throw new ArgumentNullException("Model cannot be null.");

            view.SubmitButton.Pressed += OnSubmitButtonPressed;
        }

        public void LoadFromModel()
        {
            view.NameField.FieldTextBox.Text = model.Name;
            view.SurnameField.FieldTextBox.Text = model.Surname;
            view.CreditCardNumber.FieldLabel.Text = model.CreditCardNumber;
            view.ExpirationMonth.FieldLabel.Text = model.ExpirationDateMonth;
            view.ExpirationYear.FieldTextBox.Text = model.ExpirationDateYear;
            view.CVC.FieldTextBox.Text = model.CVC;
            view.MotherMaidenName.FieldTextBox.Text= model.MotherMaidenName;
        }

        public void SaveToModel()
        {
            model.Name = view.NameField.FieldTextBox.Text;
            model.Surname = view.SurnameField.FieldTextBox.Text;
            model.CreditCardNumber = view.CreditCardNumber.FieldTextBox.Text;
            model.ExpirationDateMonth = view.ExpirationMonth.FieldTextBox.Text;
            model.ExpirationDateYear = view.ExpirationYear.FieldTextBox.Text;
            model.CVC = view.CVC.FieldTextBox.Text;
            model.MotherMaidenName = view.MotherMaidenName.FieldTextBox.Text;
        }

        private Message Model2IacMessage()
        {
            view.Engine.Log("Creating example data");
            var exampleData = new MyTableData
            {
                Instance = model.CreditCardNumber,
                FirstName = model.Name,
                LastName = model.Surname,
                CreditCardNumber = model.CreditCardNumber,
                ExpirationMonth = model.ExpirationDateMonth,
                ExpirationYear = model.ExpirationDateYear,
                CVC = model.CVC,
                MotherMaidenName = model.MotherMaidenName,
                RequestSendTime = DateTime.Now,
                RequestReceiveTime = DateTime.Now,
            };
            view.Engine.Log("Creating message");
            return new CreateRow
            {
                ExampleData = exampleData,
            };
        }

        private void OnSubmitButtonPressed(object sender, EventArgs e)
        {
            var description = String.Empty;
            try
            {
                SaveToModel();
                var response = view.Element.SendMessage(Model2IacMessage(), new TimeSpan(0, 0, 30));

                description = ((CreateRowResponse)response).Description;
            } catch (TimeoutException)
            {
                description = "Did not receive a response in time.";
            }

            view.ResponseLabel.Text = description;
        }
    }
}
