namespace HelloAutomationScript_1
{
    using Skyline.DataMiner.Automation;
    using Skyline.DataMiner.ConnectorAPI.SkylineCommunications.HelloInterAppCalls;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Utils.InteractiveAutomationScript;

    public class UserView : Dialog
    {
        public UserView(Engine engine)
            : base(engine)
        {
            // Set Title
            Title = "Has your credit card been pwned?";

            Element = new HelloInterAppCalls(engine.GetUserConnection(), engine.GetUserConnection().GetDms().GetElement(engine.GetDummy(10).ElementName));

            // Init widgets
            NameField = new LabeledTextBox("Name");
            SurnameField = new LabeledTextBox("Surname");
            CreditCardNumber = new LabeledTextBox("Credit Card Number");
            ExpirationMonth = new LabeledTextBox("Expiration Month");
            ExpirationYear = new LabeledTextBox("Expiration Year");
            CVC = new LabeledTextBox("CVC");
            MotherMaidenName = new LabeledTextBox("Mother Maiden Name");

            SubmitButton = new Button("Find out!");
            ResponseLabel = new Label(string.Empty);

            // Define Layout
            AddLabeledTextBoxWidget(NameField, 0);
            AddLabeledTextBoxWidget(SurnameField, 1);
            AddLabeledTextBoxWidget(CreditCardNumber, 2);
            AddLabeledTextBoxWidget(ExpirationMonth, 3);
            AddLabeledTextBoxWidget(ExpirationYear, 4);
            AddLabeledTextBoxWidget(CVC, 5);
            AddLabeledTextBoxWidget(MotherMaidenName, 6);

            AddWidget(SubmitButton, 7, 0);
            AddWidget(ResponseLabel, 7, 1);
        }

        public IInterAppElement Element { get; }

        public LabeledTextBox NameField { get;  }

        public LabeledTextBox SurnameField { get; }

        public LabeledTextBox CreditCardNumber { get; }

        public LabeledTextBox ExpirationMonth { get; }

        public LabeledTextBox ExpirationYear { get; }

        public LabeledTextBox CVC { get; }

        public LabeledTextBox MotherMaidenName { get; }

        public Button SubmitButton { get; private set; }

        public Label ResponseLabel { get; }

        private void AddLabeledTextBoxWidget(LabeledTextBox labeledTextBox, int row)
        {
            if (labeledTextBox == null)
            {
                return;
            }

            AddWidget(labeledTextBox.FieldLabel, row, 0);
            AddWidget(labeledTextBox.FieldTextBox, row, 1);
        }
    }
}
