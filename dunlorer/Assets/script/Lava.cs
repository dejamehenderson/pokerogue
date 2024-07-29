using UnityEngine;

public class Lava : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Call the method to kill the player
            KillPlayer(other.gameObject);
        }
    }

    void KillPlayer(GameObject player)
    {
        // You can implement your logic here. For example:
        // - Reduce player's health to zero
        // - Reset player's position
        // - Display game over screen
        // - etc.
        Debug.Log("Player touched the lava! Player is dead.");

        // Example: Reset player's position (assuming you have a spawn point)
        player.transform.position = new Vector3(0, 1, 0); // Example position, set to your spawn point

        // Alternatively, you might have a Player script with a Kill() method
        // player.GetComponent<Player>().Kill();
    }
}
