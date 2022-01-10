using UnityEngine;
using System.Collections;

public class MoveObjects : MonoBehaviour
{


    // 如果 點擊滑鼠左鍵的話  讓物件在update涵式=>物件位置=左鍵持續按的位置   然而這邊的效果會變成一點滑鼠左鍵物件物件就會移到左鍵點擊的位置
    // if(Input.GetMouseButton(0)) { gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition)};
    private Vector3 offset;
    private float MousePower = 10;

    void OnMouseDown()
    {

        offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));

        //滑鼠放開瞬間開啟旋轉鎖定
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;

    }

    void OnMouseUp()
    {
        //滑鼠放開瞬間的位移量
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        GetComponent<Rigidbody2D>().velocity = new Vector2(x * 0, y * 0);

        //滑鼠放開瞬間解除旋轉鎖定
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }
}

