using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    // Skrip GameManager untuk mengakses skor maksimal
    [SerializeField]
    private GameManager gameManager;
    public PlayerControl player;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // Jika objek tersebut bernama "Ball":
        if (hitInfo.name == "Ball")
        {
            // Tambahkan skor ke pemain
            player.IncrementScore();
            hitInfo.gameObject.SendMessage("RestartGame",
            2.0f, SendMessageOptions.RequireReceiver);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
