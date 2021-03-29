using UnityEngine;
using System.Collections;
using System.Linq;

public class Pacdot : MonoBehaviour {

    public enum State 
    {
        Dot,
        Slow,
        Disabled
    }

    public State state = State.Dot;

    private GameManager GM;

    // Use this for initialization
    void Start()
    {
        GM = GameObject.Find ("Game Manager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "pacman")
        {
            switch (state)
            {
            case State.Dot:
                GameManager.score += 10;
                Pacdot[] pacdots = Object.FindObjectsOfType<Pacdot>(); // rip performance
                if (GameManager.scared) {
                    Disable();
                } else {
                    Slow();
                }
                //Destroy (gameObject);

                if (!pacdots.Any(x => x.state == State.Dot)) {
                    GameObject.FindObjectOfType<GameGUINavigation>().LoadLevel ();
                }

                /*if (pacdots.Length == 1) {
                    GameObject.FindObjectOfType<GameGUINavigation> ().LoadLevel ();
                }*/
                break;

            case State.Slow:
                if (GameManager.scared) {
                    Disable();
                }
                break;

            case State.Disabled:
                if (!GameManager.scared) {
                    if (GM.alwaysLeaveSlow) {
                        Slow ();
                    }
                }
                break;
            }
        }
    }

    public void Disable()
    {
        state = State.Disabled;
        GetComponent<SpriteRenderer>().color = Color.black;
    }

    public void Slow()
    {
        state = State.Slow;
        GetComponent<SpriteRenderer>().color = Color.cyan;
    }
}
