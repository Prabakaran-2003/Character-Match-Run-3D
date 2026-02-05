using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterData characterData;
    public float speed = 5f;

    void Update()
    {
        if (GameManager.Instance.isGameOver) return;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v);
        transform.Translate(move * speed * Time.deltaTime, Space.World);
    }

    public void CheckItem(ItemData item)
    {
        if (item == characterData.correctItem)
            GameManager.Instance.AddScore();
        else
            GameManager.Instance.GameOver();
    }
}