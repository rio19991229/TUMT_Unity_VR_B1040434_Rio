using UnityEngine;

public class door : MonoBehaviour
{
    private void Update()
    {
        if (ball.haveba && cube.havecu && cy.havecy && ca.haveca)
        {
            Destroy(gameObject);
            print("摧毀");
        }
    }

}
