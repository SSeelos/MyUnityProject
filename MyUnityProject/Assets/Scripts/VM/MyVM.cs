using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class MB : MonoBehaviour
{
    UIDocument document;
    VisualElement root;
    VisualElement menuV;

    Button menuBtn;
    Button returnBtn;
    void Awake()
    {
        document = GetComponent<UIDocument>();
        root = document.rootVisualElement;
        menuV = root.Q<VisualElement>(nameof(menuV));
        returnBtn = menuV.Q<Button>(nameof(returnBtn));
    }
    private void OnEnable()
    {
        menuBtn = document.rootVisualElement.Q<Button>(nameof(menuBtn));
        menuBtn.clicked += OnMenuBtnClicked;
        returnBtn.clicked += OnReturnBtnClicked;
    }

    private void OnMenuBtnClicked()
    {
        menuV.style.display = DisplayStyle.Flex;
    }
    private void OnReturnBtnClicked()
    {
        menuV.style.display = DisplayStyle.None;
    }
}