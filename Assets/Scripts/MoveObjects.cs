using UnityEngine;
using System.Collections;

public class MoveObjects : MonoBehaviour
{


    // �p�G �I���ƹ����䪺��  ������bupdate�[��=>�����m=������������m   �M�ӳo�䪺�ĪG�|�ܦ��@�I�ƹ����䪫�󪫥�N�|���쥪���I������m
    // if(Input.GetMouseButton(0)) { gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition)};
    private Vector3 offset;
    private float MousePower = 10;

    void OnMouseDown()
    {

        offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));

        //�ƹ���}�����}�ұ�����w
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;

    }

    void OnMouseUp()
    {
        //�ƹ���}�������첾�q
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        GetComponent<Rigidbody2D>().velocity = new Vector2(x * 0, y * 0);

        //�ƹ���}�����Ѱ�������w
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }
}

