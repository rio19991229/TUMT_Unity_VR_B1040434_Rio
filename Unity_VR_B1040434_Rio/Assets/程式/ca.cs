using UnityEngine;

public class ca : MonoBehaviour
{
    public static bool haveca;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "膠囊體")
        {
            haveca = true;
            print("膠囊");
        }
    }
}
