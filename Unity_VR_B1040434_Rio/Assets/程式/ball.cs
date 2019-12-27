using UnityEngine;

public class ball : MonoBehaviour
{
    public static bool haveba;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "球體")
        {
            haveba = true;
            print("球體");
        }
    }
}
