using UnityEngine.SceneManagement;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    private int bossHealth = 800;
    Rigidbody2D bossRB;
    Vector2[] bossPositions = new Vector2[9]; //positions after taking damage
    Vector2[] bossFatiguePos = new Vector2[2];//positions after taking huge damage

    int tempHealth;
    // Start is called before the first frame update
    void Start()
    {
        bossRB = GetComponent<Rigidbody2D>();
        bossPositions[0] = new Vector2(74.56f, 44.71f);
        bossPositions[1] = new Vector2(70.56f, 46.63f);
        bossPositions[2] = new Vector2(74.67f, 47.5f);
        bossPositions[3] = new Vector2(82.08f, 44.71f);
        bossPositions[4] = new Vector2(77.888f, 46.63f);
        bossPositions[5] = new Vector2(82.45f, 47.5f);
        bossPositions[6] = new Vector2(86.21f, 46.63f);
        bossPositions[7] = new Vector2(89.52f, 44.71f);
        bossPositions[8] = new Vector2(93.56f, 42.85f);
        
        bossFatiguePos[0] = new Vector2(73.61f, 40.07f);
        bossFatiguePos[1] = new Vector2(96f, 40.07f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //for every 50 damage done, go to next place
        if(bossHealth <= 750 && bossHealth >= 700){
            bossRB.transform.position = bossPositions[0];
        } else if (bossHealth <= 699 && bossHealth >= 650) {
            bossRB.transform.position = bossPositions[1];
        } else if (bossHealth <= 649 && bossHealth >= 600) {
            bossRB.transform.position = bossPositions[2];
        } else if (bossHealth <= 599 && bossHealth >= 550) {
            bossRB.transform.position = bossPositions[3];
        } else if (bossHealth <= 549 && bossHealth >= 400) {
            bossRB.transform.position = bossFatiguePos[0];
        } else if (bossHealth <= 399 && bossHealth >= 350) {
            bossRB.transform.position = bossPositions[4];
        } else if (bossHealth <= 349 && bossHealth >= 300) {
            bossRB.transform.position = bossPositions[5];
        } else if (bossHealth <= 299 && bossHealth >= 250) {
            bossRB.transform.position = bossPositions[6];
        } else if (bossHealth <= 249 && bossHealth >= 200) {
            bossRB.transform.position = bossPositions[7];
        } else if (bossHealth <= 199 && bossHealth >= 150) {
            bossRB.transform.position = bossPositions[8];
        } else if (bossHealth <= 149 && bossHealth >= 1) {
            bossRB.transform.position = bossFatiguePos[1];
        } else if (bossHealth <= 0) {
            SceneManager.LoadScene(3);
        }
    }

    public void TakeDamage(int damage){
        bossHealth -= damage;
        if(bossHealth >= 0){
            //go to win condition
            Debug.Log("win");
        }
    }
}
