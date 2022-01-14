using UnityEngine;

public class DoorOpen : MonoBehaviour
{


    public bool fire, mountain, water;

    public Animator leftDoorOpening, rightDoorOpening;

    public GameObject door, leftDoor, rightDoor;

    private void Start()
    {
        leftDoorOpening = GetComponent<Animator>();

        rightDoorOpening = GetComponent<Animator>();

        door.SetActive(true);

    }


    private void Update()
    {
        if (fire && mountain && water)
        {
            door.SetActive(false);

            leftDoor.SetActive(true);

            rightDoor.SetActive(true);

            leftDoorOpening.SetBool("�H�����L�r�J", true);

            rightDoorOpening.SetBool("�H�����L�r�J", true);
        }
    }

}
