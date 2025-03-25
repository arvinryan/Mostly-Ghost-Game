using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            print("ENTER");
        }
    }

    void OnTriggerStay(Collider other)
    {
         if (other.gameObject.tag == "enemy")
        {
            print("STAY");
        }
    }

    void OnTriggerExit(Collider other)
    {
         if (other.gameObject.tag == "enemy")
        {
            print("EXIT");
        }

    }

}
