using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ShowWhite : MonoBehaviour
{
    [Header("拖拽场景里的 Global Volume")]
    public Volume globalVolume;

    private ColorAdjustments colorAdjustments;
    private Color originalFilter;

    void Start()
    {
        if (globalVolume != null && globalVolume.profile != null)
        {
            if (globalVolume.profile.TryGet(out colorAdjustments))
            {
                originalFilter = colorAdjustments.colorFilter.value;
            }
            else
            {
                Debug.LogWarning("Global Volume Profile 没有 Color Adjustments！");
            }
        }
    }

    void OnEnable()
    {
        if (colorAdjustments != null)
        {
            // 物体显示时，把 Volume 的颜色改成白色
            colorAdjustments.colorFilter.value = Color.white;
        }
    }

    void OnDisable()
    {
        if (colorAdjustments != null)
        {
            // 物体隐藏时恢复原来的颜色
            colorAdjustments.colorFilter.value = originalFilter;
        }
    }
}
