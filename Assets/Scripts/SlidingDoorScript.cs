
using UnityEngine;

public class SlidingDoorScript : MonoBehaviour
{
    public GameObject trigger;
    public GameObject leftDoor;
    public GameObject rightDoor;

    Animator leftAnim;
    Animator rightAnim;
    // Start is called before the first frame update
    void Start()
    {
        leftAnim = leftDoor.GetComponent<Animator>();
        rightAnim = rightDoor.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            leftAnim.SetBool("slide", true);
            rightAnim.SetBool("slide", true);
        }

        if (coll.gameObject.tag == "Enemy")
        {
            leftAnim.SetBool("slide", true);
            rightAnim.SetBool("slide", true);
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            leftAnim.SetBool("slide", false);
            rightAnim.SetBool("slide", false);
        }

        if (coll.gameObject.tag == "Enemy")
        {
            leftAnim.SetBool("slide", false);
            rightAnim.SetBool("slide", false);
        }
    }

    void SlideDoors(bool state)
    {
        leftAnim.SetBool("Slide", state);
        rightAnim.SetBool("Slide", state);
    }

}
