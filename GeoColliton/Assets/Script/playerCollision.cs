using UnityEngine;

public class playerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter (Collision corllisionInfo)
    {
        if (corllisionInfo.collider.tag == "modBlok")
        {
            movement.enabled = true;
            //FindObjectOfType<gameManager>().EndGame();
        }
    }

}
