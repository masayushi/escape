using UnityEngine;


/// <summary>
/// ����m���~�ܫ��w�a�I���奻�A�i��|�ܱ`�Ρ�
/// </summary>
public class MoveSystem : MonoBehaviour
{
    public GameObject correctForm;
    private bool moving;
    private bool finish;

    private float startPosX;

    private float startPosY;

    private Vector3 restPositiion;

    private void Start()
    {
        restPositiion = this.transform.localPosition;
    }

    private void Update()
    {
        if (finish == false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;

        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            finish = true;
        }
        else
        {
            this.transform.localPosition = new Vector3(restPositiion.x, restPositiion.y, restPositiion.z);
        }
    }
}
