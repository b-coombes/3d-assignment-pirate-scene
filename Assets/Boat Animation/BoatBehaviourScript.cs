using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatBehaviourScript : MonoBehaviour
{
    public Animator animator;
    public bool in_area = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("pressed");
            if (in_area == true)
            {
                animator.SetTrigger("Push");
                print("pushed");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            in_area = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            in_area = false;
        }
    }

}
