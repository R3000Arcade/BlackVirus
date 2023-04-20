using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	
	public Hud hud;
    public Renderer fondo;
	public float inputHorizontal;
	public float inputVertical;
	public GameObject enemigos;
	public Transform CreateEnemy;
	private int vidas = 3;
    internal static object Instancie;


	public GameManager() { }
    void Start()
    {
       //InvokeRepeating("CrearEnemigos",5f,3f);
		
    }


    void Update()
    {
		
        inputHorizontal = Input.GetAxis("Horizontal");
		if(inputHorizontal > 0)
		{
			fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(inputHorizontal,0) * Time.deltaTime;
		}
		
		
    }
	
	
	public void CrearEnemigos()
	{
		Instantiate(enemigos, CreateEnemy.position,CreateEnemy.rotation);
	}


	public void PerderVidas()
	{
		vidas = -1;
		new Hud().DesactivaeVida(vidas);
	}
}
