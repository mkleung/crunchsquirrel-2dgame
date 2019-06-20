using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{

    public int health;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -7) {
            Die();
        }

    }

    // Restart the Scene
    void Die() {
        SceneManager.LoadScene("Prototype1");
   
    }
}
