using UnityEngine;

/// <summary>
/// 透過滑鼠滾輪將霧散去的腳本
/// 滑鼠滑入時物件動畫開啟
/// </summary>
public class FogOut : MonoBehaviour
{
    public float mouse;
    public SpriteRenderer fog;


    public bool ischanging;

    public Animator changeSize;

    private void Update()
    {
        mouse = Input.GetAxis("Mouse ScrollWheel");

        if (mouse > 0)
        {
            fog.color = new Color(255, 255, 255, 90);
        }

        if (mouse < 0)
        {
            fog.color = new Color(255, 255, 255, 0);
        }
    }


    /// <summary>
    /// 滑入時特效
    /// </summary>
    private void OnMouseEnter()
    {
        if (ischanging)
        {
            changeSize.SetBool("被點擊時", false);
        }
        else if (!ischanging)
        {
            changeSize.SetBool("被點擊時", true);
        }
    }
}
