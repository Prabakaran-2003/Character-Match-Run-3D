using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ItemData itemData;

    void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            player.CheckItem(itemData);
            Destroy(gameObject);
        }
    }
}