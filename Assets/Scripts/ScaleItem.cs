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
                ani.SetBool("持有物品縮放", true);

                buttonControlUpAndDown = true;
            }
            else
            {
                ani.SetBool("持有物品縮放", false);

                buttonControlUpAndDown = false;
            }
        }
    }
}
