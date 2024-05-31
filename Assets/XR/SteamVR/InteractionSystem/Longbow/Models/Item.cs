using UnityEngine;
using System.Collections;

public enum ItemType
{
	Object,
	Test
}
public class Item : MonoBehaviour
{
	public ItemType type;
	bool flag = false;

	public void Interaction()
	{
		if (type == ItemType.Object)
		{
			flag = !flag;
			GetComponentInParent<Animator>().SetBool("1", flag);
			GetComponentInParent<Animator>().SetBool("2", !flag);
		}
		if (type == ItemType.Test)
		{
			Destroy(gameObject);
		}
	}
}



