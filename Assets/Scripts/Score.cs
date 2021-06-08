using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
  private int PlayerScore=1;
    [SerializeField]
    private int FinalScore;
    [SerializeField]
    private int ChangeScore;
    //  public int obsScore;
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private PositionContainer positionContainer;
    [SerializeField]
    private List<GameObject> ClonePlayers;
    private GameObject clone;
    

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
                
                clone= Instantiate(Player, transform.position+positionContainer.listOfPosition[i].transform.position, transform.rotation, transform);
                ClonePlayers.Add(clone);

                clone.transform.localScale = Vector3.one;
           
               PlayerScore++;
              
            }
            
            

        }
        else if (other.CompareTag("DestroyObstacle"))
        {
            other.GetComponent<BoxCollider>().enabled = false;
            // int desScore = other.GetComponent<DestroyMultiplayer>().DestScore;
             int obsScore = other.GetComponent<Multiplayer>().ObstScore;
            ChangeScore = PlayerScore - obsScore;
            FinalScore = PlayerScore - ChangeScore;
            for (int i = 0; i < FinalScore; i++)
            {
                Debug.Log("mtnuma");
                Destroy(ClonePlayers[i]);
                // ClonePlayers[i].SetActive(false);
                ClonePlayers.Remove(ClonePlayers[i]);

                PlayerScore--;
            }


        }



    }

     
            
}

