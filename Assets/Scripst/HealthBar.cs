using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthBar : MonoBehaviour
{
	public static uint WinScore = 0;
	public static uint LooseScore = 0;

	public static uint neededScore = 5;
	public Image bar;
    private float fill;
	private float destroyTime;
	public static uint aimDestr = 0;
	public GameObject ExplosionEffect;
	// Start is called before the first frame update
	void Start()
    {
		fill = 1.0f; //����� ��������� �� 100%
    }

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.tag == "Ball") //���� ���������� � �������� ��� ����� Ball
		{
			if (gameObject.tag == "Gus")
			{
				Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
				Destroy(coll.gameObject); //�������� ����
				Destroy(gameObject, destroyTime); //�������� ������� (����)
				aimDestr = 0;
				SceneManager.LoadScene("Lose");
				LooseScore++;
			}
			if (gameObject.tag == "Target")
			{
				fill -= 0.5f;
				bar.fillAmount = fill; //������������� �����
				Destroy(coll.gameObject); //�������� ����
				Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
				if (fill == 0f)
                {
					Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
					Destroy(gameObject, destroyTime); //�������� ������� (����)
					Destroy(coll.gameObject); //�������� ����
					aimDestr++;
				}
			}
			if (gameObject.tag == "Target1")
			{
				fill -= (float)1 / 3;
				bar.fillAmount = fill; //������������� �����
				Destroy(coll.gameObject); //�������� ����
				Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
				if (fill <= 0f)
				{
					Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
					Destroy(gameObject, destroyTime); //�������� ������� (����)
					Destroy(coll.gameObject); //�������� ����
					aimDestr++;
				}
			}
		}
	}

	// Update is called once per frame
	void Update()
    {
		if (aimDestr == neededScore)
		{
			Destroy(gameObject);
			aimDestr = 0;
			SceneManager.LoadScene("Win");
			WinScore++;
		}
	}
}
