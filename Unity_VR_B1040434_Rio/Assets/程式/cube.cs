using UnityEngine;

public class cube : MonoBehaviour
{
    public static bool havecu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "方體")
        {
            havecu = true;
        }
    }
}
