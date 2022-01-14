using UnityEngine;

/// <summary>
/// �z�L�ƹ��u���N�����h���}��
/// �ƹ��ƤJ�ɪ���ʵe�}��
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
