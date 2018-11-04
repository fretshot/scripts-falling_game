using UnityEngine;

public class Player_Control : MonoBehaviour {

    public float speed = 3.0F;
    public static bool inMovement = false;

    public GameObject helpLayout;

    public void Awake(){
        inMovement = false;
    }

    private void Start(){
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
        inMovement = false;

    }

    void Update(){
        if (Input.touchCount > 0){
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2 ){
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                inMovement = true;
                helpLayout.SetActive(false);
            }
            else if (touch.position.x > Screen.width / 2 ){
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                inMovement = true;
                helpLayout.SetActive(false);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            inMovement = true;
            helpLayout.SetActive(false);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            inMovement = true;
            helpLayout.SetActive(false);
        }
    }
}
