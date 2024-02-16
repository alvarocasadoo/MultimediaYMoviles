using UnityEngine;

public class DestruirAlColisionar : MonoBehaviour

{
    public Score score;

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("El personaje me ha tocado");
        score.totalScore += 100;
        Destroy(this.gameObject);
        


    }
}
