using UnityEngine;

public class PlayerColission : MonoBehaviour
{

    public PlayerMovement movement;
  

 void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We Hit Something Chief");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
