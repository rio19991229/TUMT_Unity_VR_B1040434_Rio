using UnityEngine;

public class cy : MonoBehaviour
{
    public static bool havecy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "圓柱體")
        {
            havecy = true;
            print("圓柱");
        }
    }
}
