using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BusCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (collision.gameObject.name == "Robot_Transform")
        {
            if (currentScene.name.Equals("CoE"))
            {
                SceneManager.LoadScene("ECC");
                print("Warp to ECC");
            }
            else if (currentScene.name.Equals("ECC"))
            {
                SceneManager.LoadScene("MainScene");
                print("Warp to Main Gate");
            }
            else if (currentScene.name.Equals("MainScene"))
            {
                SceneManager.LoadScene("CoE");
                print("Warp to CoE");
            }
            else
            {
                print("Warp ERROR");
            }

        }
    }
}
