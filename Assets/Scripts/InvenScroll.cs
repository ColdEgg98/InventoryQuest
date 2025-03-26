using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InvenScroll : ScrollRect
{
    public override void OnScroll(PointerEventData data)
    {
        if (verticalNormalizedPosition >= 1f && data.scrollDelta.y > 0)
        {
            // ������ ���� ������ �� �� �� ��
            return;
        }

        base.OnScroll(data);
    }
}
