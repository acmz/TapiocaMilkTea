using UnityEngine;

public class GenerateMilkTea : MonoBehaviour
{

    public GameObject milkTeaPrefab;
    private float poulTime = 0f;
    private float maxPoulTime = 0f;

    // Start is called before the first frame update
    void Start() {

        maxPoulTime = 3.8f;
        //maxPoulTime = Random.Range(5.0f, 6.0f);

    }

    // Update is called once per frame
    void Update() {

        poulTime += Time.deltaTime;

        if(poulTime > maxPoulTime) {
            return;
        }

        GameObject milkTeaInstance = Instantiate(milkTeaPrefab) as GameObject;
        milkTeaInstance.transform.position = new Vector3(0, 6, 0);

    }
}
