using UnityEngine;

/// <summary>
/// �z�L�ƹ��u���N�����h���}��
/// </summary>
public class FogOut : MonoBehaviour
{
    public float mouse;
    public SpriteRenderer fog;

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
}
