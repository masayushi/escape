using UnityEngine;

/// <summary>
/// �B������奻
/// </summary>
public class TakeObject : MonoBehaviour
{
    [SerializeField]
    private GameObject takegressimg;

    public static bool youtakegrass;

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
}
