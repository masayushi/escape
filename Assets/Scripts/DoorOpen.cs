using UnityEngine;

public class DoorOpen : MonoBehaviour
{


    public bool fire, mountain, water, opening;

    public Animator leftDoorOpening, rightDoorOpening;

    public GameObject door, leftDoor, rightDoor;

    public GameObject pf, pm, pw;

    private void Start()
    {
        //leftDoorOpening = GetComponent<Animator>();

        //rightDoorOpening = GetComponent<Animator>();

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

            opening = true;
        }
        else
        {
            opening = false;
        }
    }
}

