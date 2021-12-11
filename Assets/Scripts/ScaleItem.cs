using UnityEngine;
using UnityEngine.UIElements;

public class ScaleItem : MonoBehaviour
{
    public bool buttonControlUpAndDown;

    public float item;

    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (buttonControlUpAndDown)
            {
                ani.SetBool("�������~�Y��", true);

                buttonControlUpAndDown = true;
            }
            else
            {
                ani.SetBool("�������~�Y��", false);

                buttonControlUpAndDown = false;
            }
        }
    }
}
