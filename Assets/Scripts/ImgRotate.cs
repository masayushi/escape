using System;
using UnityEngine;
using UnityEngine.UI;

// ����Ϥ�UI�奻
public class ImgRotate : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameControl.youTakePiece)
        {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
