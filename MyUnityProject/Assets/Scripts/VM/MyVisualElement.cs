
using UnityEngine.UIElements;

[UxmlElement]
public partial class MyVisualElement : VisualElement
{
    string _myString;
    [UxmlAttribute]
    public string MyString
    {
        get => _myString;
        set
        {
            _myString = value;
            //update UI?
        }
    }
    public MyVisualElement()
    {
        var container = new VisualElement();
        container.name = "myContainerName";
        var label = new Label("myLabel");
        label.name = "myLabelName";

        base.Add(container);
        container.Add(label);
    }
}