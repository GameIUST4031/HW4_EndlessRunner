using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ColiisionDetect : MonoBehaviour
{
    private GameObject player;
    Animator animator_Collision;
    private GameObject GameOver;
    private PopupMessage _popupMessage;
    GameObject gamemanager;
    GameObject Player;
    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        animator_Collision.speed = 2.5f;
        animator_Collision.Play("Stumble Backwards");
        StartCoroutine(ShowPopupAfterAnimation());
    }
    private IEnumerator ShowPopupAfterAnimation()
    {
        // Wait for the length of the animation
        float animationDuration = animator_Collision.GetCurrentAnimatorStateInfo(0).length;

        yield return new WaitForSeconds(animationDuration);

        // Now show the popup message
        _popupMessage = gamemanager.GetComponent<PopupMessage>();
        PlayerMovement p = player.GetComponent<PlayerMovement>();
        _popupMessage.Open("1.png", $"Highest Score:\t\t{p.highScore}",$"Score:\t\t{p.currentScore}");
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator_Collision = GameObject.FindGameObjectWithTag("EVE").GetComponent<Animator>();
        GameOver = FindInactiveGameObjectByTag("GameOver");
        Debug.Log(GameOver.activeSelf.ToString());
        gamemanager= GameObject.FindGameObjectWithTag("GameManager");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame

    public static GameObject FindInactiveGameObjectByTag(string tag)
    {
        // Fetch all GameObjects in the scene, including inactive ones
        GameObject[] allGameObjects = Resources.FindObjectsOfTypeAll<GameObject>();

        // Use LINQ to find the first inactive GameObject with the specified tag
        GameObject foundGameObject = allGameObjects
            .Where(g => g.tag == tag && !g.activeInHierarchy) // Check for the tag and inactive state
            .FirstOrDefault(); // Get the first match or null if none found

        return foundGameObject; // Return the found GameObject or null
    }
}