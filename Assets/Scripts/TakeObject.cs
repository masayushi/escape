using UnityEngine;

/// <summary>
/// �B������奻
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
    /// �I���ìB��
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
    /// �ƤJ�ɯS��
    /// </summary>
    private void OnMouseEnter()
    {
        if (ischanging)
        {
            changeSize.SetBool("�Q�I����", false);
        }
        else if (!ischanging)
        {
            changeSize.SetBool("�Q�I����", true);
        }
    }
}
