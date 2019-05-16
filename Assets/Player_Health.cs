using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{

    public bool hasDied;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        hasDied = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -7) {
            hasDied = true;
        }

        if (hasDied == true) {
            StartCoroutine("Die");
        }
    }

    // Restart the Scene
    IEnumerator Die() {
        SceneManager.LoadScene("Prototype1");
        yield return null;
    }
}
