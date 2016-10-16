using UnityEngine;
using System.Collections;

public class Splitting : MonoBehaviour {
public Camera cam;
public GameObject prefab;
public GameObject mainslime;
private GameObject oldslime;

	// Use this for initialization
	void Start () {
		
   
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftControl))
    {
        GameObject newslime =(GameObject) Instantiate(prefab, new Vector3( 1+ mainslime.transform.position.x , mainslime.transform.position.y, mainslime.transform.position.z), Quaternion.identity);
		 newslime.transform.SetParent(this.transform);
	}
	if (Input.GetMouseButtonDown(0))
	{
		RaycastHit2D Seer = Physics2D.Raycast(new Vector2(cam.ScreenToWorldPoint(Input.mousePosition).x,cam.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 0f);
		if(Seer && Seer.transform.gameObject.tag == "Slime"){
			Debug.Log(Seer.transform.name);
			oldslime = mainslime;
             mainslime = Seer.transform.gameObject;
			 oldslime.GetComponent<PlayerInput>().enabled = false;
			 mainslime.GetComponent<PlayerInput>().enabled = true;
		}
		}
		
	}
	}

