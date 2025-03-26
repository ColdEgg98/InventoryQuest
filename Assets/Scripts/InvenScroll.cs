using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InvenScroll : ScrollRect
{
    public override void OnScroll(PointerEventData data)
    {
        if (verticalNormalizedPosition >= 1f && data.scrollDelta.y > 0)
        {
            // 能刨明 力老 困俊老 锭 荣 诀 遏
            return;
        }

        base.OnScroll(data);
    }
}
