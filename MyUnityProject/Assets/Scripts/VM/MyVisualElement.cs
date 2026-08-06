
using UnityEngine.UIElements;

[UxmlElement]
public partial class MyVisualElement : VisualElement
{
    string _myString;
    [UxmlAttribute]
    public string MyString
    {
        get => _myString;
        set => _myString = value;
    }
    [UxmlAttribute]
    public string MyLabel
    {
        get => label.text;
        set => label.text = value;
    }
    [UxmlAttribute]
    public string MyValue
    {
        get => labelValue.text;
        set => labelValue.text = value;
    }
    Label label;
    Label labelValue;
    public MyVisualElement()
    {
        label = this.AddOfType(new Label("myLabel")
        {
            name = "myLabelName"
        });
        var container = this.AddOfType(new VisualElement()
        {
            name = "myContainerName"
        });
        container.AddOfType(new Label("myValueLabel")
        {
            name = "myValueLabelName",
            text = "Value:"
        });
        labelValue = container.AddOfType(new Label("myValue")
        {
            name = "myValueName"
        });
    }
}