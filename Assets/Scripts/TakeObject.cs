using UnityEngine;

/// <summary>
/// 拾取物件文本
/// </summary>
public class TakeObject : MonoBehaviour
{
    [SerializeField]
    private GameObject takegressimg;

    public static bool youtakegrass;

    public bool ischanging;

    public Animator changeSize;

    private void Start()
    {
        takegressimg.SetActive(true);
        youtakegrass = true;
    }

    /// <summary>
    /// 點擊並拾取
    /// </summary>
    private void OnMouseDown()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            youtakegrass = false;

            takegressimg.SetActive(false);
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
