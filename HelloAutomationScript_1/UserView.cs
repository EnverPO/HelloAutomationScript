namespace HelloAutomationScript_1
{
    using Skyline.DataMiner.Automation;
    using Skyline.DataMiner.Utils.InteractiveAutomationScript;

    public class UserView : Dialog
    {
        private Label NameLabel;

        public UserView(Engine engine)
            : base(engine)
        {
            // Set Title
            Title = "Hello Automation!";

            // Init widgets

            // Name Label
            NameLabel = new Label("Name");
            NameTextBox = new TextBox();
            SendButton = new Button("Send");

            // Define Layout
            AddWidget(NameLabel, 0, 0);
            AddWidget(NameTextBox, 0, 1);
            AddWidget(SendButton, 1, 0);
        }


        public TextBox NameTextBox { get; private set; }

        public Button SendButton { get; private set; }
    }
}
