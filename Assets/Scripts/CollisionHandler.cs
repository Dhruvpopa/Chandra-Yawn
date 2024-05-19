using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly" :
                Debug.Log("Bumped into launching Pad");
                break;

            case "Finish" :
                Debug.Log("Bumped into landing Pad");
                break;

            case "Fuel":
                Debug.Log("You picked up fuel");
                break;

            default:
                SceneManager.LoadScene(0);
                break;

        }
    }
}
