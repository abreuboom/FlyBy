using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public GameObject obstacle;
	public GameObject powerup;
	public GameObject boulder;
	
	float timeElapsed = 0;
	float spawnCycle = .01f;
	//bool spawnPowerup = true;
	int spawnKind;
	
	void Update () {
		timeElapsed += Time.deltaTime;
		spawnKind = Random.Range (0, 5);
		if(timeElapsed > spawnCycle)
		{
			GameObject temp;

			 if(spawnKind <=1)
			{
				temp = (GameObject)Instantiate(obstacle);
				//Vector3 pos = temp.transform.position;
				temp.transform.position = new Vector3(Random.Range(-15, 15),Random.Range(-10, 10) , 50);
			}
			
			timeElapsed -= spawnCycle;
			//spawnPowerup = !spawnPowerup;
		}
	}
}