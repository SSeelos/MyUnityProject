using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
[RequireComponent(typeof(MyViewModel))]
public class MyView : MonoBehaviour
{
    UIDocument document;
    MyViewModel viewModel;
    VisualElement root;
    VisualElement menuV;

    Button menuBtn;
    Button returnBtn;
    Button mainMenuBtn;
    void Awake()
    {
        document = GetComponent<UIDocument>();
        viewModel = GetComponent<MyViewModel>();
        root = document.rootVisualElement;
        menuV = root.Q<VisualElement>(nameof(menuV));
        returnBtn = menuV.Q<Button>(nameof(returnBtn));
        mainMenuBtn = menuV.Q<Button>(nameof(mainMenuBtn));
    }
    private void OnEnable()
    {
        menuBtn = document.rootVisualElement.Q<Button>(nameof(menuBtn));
        menuBtn.clicked += OnMenuBtnClicked;
        returnBtn.clicked += OnReturnBtnClicked;
        mainMenuBtn.clicked += OnMainMenuBtnClicked;
    }

    private void OnMainMenuBtnClicked()
    {
        viewModel.LoadMenu();
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