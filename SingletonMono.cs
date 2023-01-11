using UnityEngine;

namespace SterlingTools
{
	public abstract class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T ins;

		public static T Instance
		{
			get
			{
				if (!ins)
				{
					ins = FindObjectOfType<T>();

					if (!ins)
					{
						GameObject gameObject = new GameObject(typeof(T).ToString());
						ins = gameObject.AddComponent<T>();
					}
					
					DontDestroyOnLoad(ins.gameObject);
				}

				return ins;
			}
		}
	}
}
