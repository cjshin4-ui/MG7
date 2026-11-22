using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour {

    [SerializeField] private Transform player;
    [SerializeField] private float interactionDistance = 10;
    [SerializeField] private GameObject[] sparrows;


    private void Update() {
        for (int i = 0; i < sparrows.Length; i++) {
            float distance = Vector3.Distance(player.position, sparrows[i].transform.position);

            if (distance <= interactionDistance) {
                sparrows[i].SetActive(true);
            }

        }


    }




}
