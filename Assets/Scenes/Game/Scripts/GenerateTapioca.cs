using UnityEngine;

public class GenerateTapioca : MonoBehaviour {

    public GameObject tapiocaPrefab;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if(!Input.GetMouseButtonDown(0)) {
            return;
        }

        GameObject tapiocaInstance = Instantiate(tapiocaPrefab) as GameObject;
        Vector3 tapiocaPosition;
        tapiocaPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        tapiocaPosition.z = 0f;
        tapiocaInstance.transform.position = tapiocaPosition;

    }
}
