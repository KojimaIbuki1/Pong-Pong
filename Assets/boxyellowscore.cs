using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxyellowscore : MonoBehaviour
{
    public PlayerControl player1;
    public PlayerControl player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Ball")
        {
            var direction = transform.InverseTransformPoint(collision.transform.position);

            if (direction.x > 0f)
            {
                player1.BonusScoreYell();
            }
            else if (direction.x < 0f)
            {
                player2.BonusScoreYell();
            }
            Destroy(this.gameObject);
        }
    }
}
