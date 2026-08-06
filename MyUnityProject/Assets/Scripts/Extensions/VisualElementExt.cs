using UnityEngine.UIElements;

public static class VisualElementExt
{
    public static T AddOfType<T>(this VisualElement subject, T other)
        where T : VisualElement
    {
        subject.Add(other);
        return other;
    }
}