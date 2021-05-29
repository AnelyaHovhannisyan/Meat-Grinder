using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   private int PlayerScore=1;
   private int FinalScore;
   private int ChangeScore;
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private PositionContainer positionContainer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle"))
        {
           
            other.GetComponent<BoxCollider>().enabled = false;
            int obsScore = other.GetComponent<Multiplayer>().ObstScore;
            ChangeScore = PlayerScore * obsScore;
            FinalScore = ChangeScore - PlayerScore;
            for (int i = 0; i < FinalScore; i++)
            {
                GameObject clone= Instantiate(Player, transform.position+positionContainer.listOfPosition[i].transform.position, transform.rotation, transform);
               

                clone.transform.localScale = Vector3.one;
           
                PlayerScore++;
              
            }
            
            

        }
    }
}
