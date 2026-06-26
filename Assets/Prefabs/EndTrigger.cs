using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
