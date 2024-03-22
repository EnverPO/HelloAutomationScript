namespace HelloAutomationScript_1
{
    using Skyline.DataMiner.Utils.InteractiveAutomationScript;

    public class LabeledTextBox
    {
        public LabeledTextBox(string labelText)
        {
            FieldLabel = new Label(labelText);
            FieldTextBox = new TextBox();
        }

        public Label FieldLabel { get; }

        public TextBox FieldTextBox { get; }
    }
}
