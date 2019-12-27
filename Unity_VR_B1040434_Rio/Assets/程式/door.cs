using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject obj;

    private void Start()
    {
        obj = GetComponent<GameObject>();

        if (ball.haveba && cube.havecu && cy.havecy && ca.haveca)
        {
            Destroy(obj);
            print("摧毀");
        }
    }
}
