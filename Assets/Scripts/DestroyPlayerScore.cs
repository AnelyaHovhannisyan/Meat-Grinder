//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DestroyPlayerScore : MonoBehaviour
//{
// //   private int DestPlayerScore=1 ;
//    private int DestFinalScore;
//    private int DestChangeScore;
//    [SerializeField]
//    private GameObject Player;
//    private Score CloneScore;

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Obstacle"))
//        {
//            Debug.Log("mtnuma");

//            other.GetComponent<BoxCollider>().enabled = false;
//             int desScore = other.GetComponent<DestroyMultiplayer>().DestScore;
//          //  int obsScore = other.GetComponent<Multiplayer>().ObstScore;
//            DestChangeScore = CloneScore.PlayerScore - desScore;
//            DestFinalScore = DestChangeScore - CloneScore.PlayerScore;
           
//            for (int i = 0; i < DestFinalScore; i++)
//            {
//                // CloneScore.ClonePlayers.Remove();
//                // Destroy(CloneScore.ClonePlayers.Remove(clone));

//                // DestPlayerScore++;
//            }
//        }
//    }
//}
