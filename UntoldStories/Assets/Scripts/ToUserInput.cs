using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToUserInput : MonoBehaviour
{
    public Animator animUserInput;
	public Animator animInputButton;
	public LevelController levelController;
    private RaycastHit hit;
    private Ray ray;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
	{
		
		
		// Funzione per controllare il tocco di un oggetto tramite mouse
		if (Input.GetMouseButtonDown(0))
        {
            
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);
			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				if (hit.transform.gameObject.tag == "Prova")
				{
					
					animUserInput.Play("UIAppear");
					animInputButton.Play("opacityButton");
					levelController.choiche = 2;
					Destroy(hit.transform.gameObject);
				}
				if (hit.transform.gameObject.tag == "Example2")
				{
					
					animUserInput.Play("UIAppear");
					animInputButton.Play("opacityButton");
					levelController.choiche = 1;
					Destroy(hit.transform.gameObject);
				}

			}
		}
		
        
        //Funzione per controllare il tocco di un oggetto con touch
        if (Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
        {
			ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);
			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
				if(hit.transform.gameObject.tag == "Prova") {
					Destroy(hit.transform.gameObject);
					animUserInput.Play("UIAppear");
					animInputButton.Play("opacityButton");
					levelController.choiche = 2;
				}

				if (hit.transform.gameObject.tag == "Example2")
				{
					Destroy(hit.transform.gameObject);
					animUserInput.Play("UIAppear");
					animInputButton.Play("opacityButton");
					levelController.choiche = 1;
				}

			}
		}
    }

}