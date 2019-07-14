using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //画面外に出たオブジェクトを破棄する
        if(transform.position.y < -7.0f) {
            Destroy(gameObject);
        }

    }
}
