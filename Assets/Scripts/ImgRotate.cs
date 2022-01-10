using System;
using UnityEngine;
using UnityEngine.UI;

// 旋轉圖片UI文本
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
