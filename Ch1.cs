using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello, Unity!");

        int level = 5;
        float strength = 15.5f;
        string playerName = "정효정";
        bool isFullLevel = false;

        //2.그룹형 변수 : 변수의 이름 뒤에 [] 붙임
        string[] monsters = { "가", "나", "다" };

        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        //3칸의 그룹형 변수를 선언
        int[] monsterLevel = new int[3];

        monsterLevel[0] = 1;

        //리스트 선언 방법
        List<string> items = new List<string>();

        //리스트 안에 삽입
        items.Add("생명물약30");
        items.Add("마나물약30");

        Debug.Log(items[0]);
        Debug.Log(items[1]);
        
        
        //리스트 안에 삭제
        items.RemoveAt(0);

        Debug.Log(items[0]);
        //Debug.Log(items[1]); --> 삭제 되었기 때문에 오류를 발생 시킴(알맞는 번지수를 찾아가지 못함 )

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        //Debug.Log("asdf" + isFullLevel); -->false 출력

        
        isFullLevel = level != fullLevel;
        //Debug.Log("asdf" + isFullLevel);-->true 출력 

        int health = 30;
        int mana = 25;

        //&& --> 모두가 참일 떄 출력 
        //bool isBadCondition = health <= 50 && mana <= 20;
        
        // ||--> 두값중 하나만 참이면 참 
        bool isBadCondition = health <= 50 || mana <= 20;

        //? A : B --> true 일때 A 출력, false 일때 B 출력 
        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("상태는? : " + condition);



        if(condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁩니다");
        }
        else
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명물약30을 사용하였습니다.");

        }
        else if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나물약30을 사용하였습니다");
        }


        switch(monsters[1])
        {
            case "가":
                Debug.Log("소형입니다");
                break;
            case "나":
                Debug.Log("중형입니다");
                break;
            case "다":
                Debug.Log("대형입니다");
                break;
        }

        //6.반복문 
        while(health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독데미지를 입었습니다 " + health);
            }
            else
            {
                Debug.Log("사망하였습니다" + health);
            }
            
            if(health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for(int i = 0; i < monsters.Length; i++)
        {
            Debug.Log("이 지역에 있는 몬스터 :" + monsters[i]);
        }

        foreach(string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터 :" + monster);
        }

    }

  
}
