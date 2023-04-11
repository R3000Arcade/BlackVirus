using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class control : MonoBehaviour
{
    private Rigidbody2D rbf2D;
    [Header("Movimiento")]
    private float movimientoHorizontal = 0f;
    [SerializeField] private float velocidadDeMovimiento;
    [Range(0, 0.3f)][SerializeField] private float suavizadoDeMovimiento;
    private Vector3 velocidad = Vector3.zero;
    private bool mirandoDerecha = true;
    [Header("Salto")]
    [SerializeField] private float fuerzaDeSalto;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private Transform controladorSuelo;
    [SerializeField] private Vector3 dimensionesCaja;
    [SerializeField] private bool enSuelo;
    private bool salto = false;
    [Header("Animacion")]
    private Animator animator;




    private void Start()
    {
        rbf2D = GetComponent<Rigidbody2D>();    
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal") * velocidadDeMovimiento;
        animator.SetFloat("Horizontal", Mathf.Abs(movimientoHorizontal ) );
        if(Input.GetButtonDown("Jump"))
        {
            salto = true;
        }

    }
    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);
        animator.SetBool("enSuelo", enSuelo);
        //Mover
        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);
        salto = false;
    }
    private void Mover(float mover,bool saltar)
    {
        Vector3 velocidadObjetivo = new Vector2(mover, rbf2D.velocity.y);
        rbf2D.velocity = Vector3.SmoothDamp(rbf2D.velocity, velocidadObjetivo, ref velocidad, suavizadoDeMovimiento);
        if(mover > 0 && !mirandoDerecha)
        {
            //Girar
            Girar();
        }
        else if(mover < 0 && mirandoDerecha)
        {
            //Girar
            Girar();
        }
        if(enSuelo && saltar)
        {
            enSuelo = false;
            rbf2D.AddForce(new Vector2(0f, fuerzaDeSalto));
        }
    }
    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;  

    }
   



}
