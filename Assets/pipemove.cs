using UnityEngine;
using UnityEngine.Serialization;

public class Pipemove : MonoBehaviour
{   [FormerlySerializedAs("movespeed")] [SerializeField]
    public int defaultMovespeed = 15;
    private float _lifeTime = 6;
    public int score = 1;
    private bool _die;



    // Update is called once per frame
    private void Update()
    {
        transform.position += Vector3.left * (float)(_calc_movespeed(score: score, defaultMovespeed) * Time.deltaTime);

        _lifeTime -= Time.deltaTime;

        if (_lifeTime <= 0) _die = true;
        if (_die) DestroyImmediate(gameObject, true);

        

    }

    public void trackScore()
    {
        score += 1;
    }

    private double _calc_movespeed(int score, int defMoveSpeed)
    {
        return score * 0.5 + defMoveSpeed;
    }
}