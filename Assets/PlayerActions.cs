using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    // when the player creates the Jump event
    public void OnJump()
    {
        // print this message to the console
        Debug.Log("The Player created our Jump InputAction");
    }

    // when the player creates the Fire event
    public void OnFire()
    {
        // print this message to the console
        Debug.Log("The Player created our Fire InputAction");
    }
}
