namespace DotFeather
{
	public abstract class Component
	{
		public Element? Element { get; private set; }

		public Transform? Transform => Element?.Transform;

		public T? GetComponent<T>() where T : Component
		{
			return (T?)(Element?.GetComponent<T>());
		}

		public virtual void OnStart() { }
		public virtual void OnUpdate() { }
		public virtual void OnDestroy() { }

		public virtual void OnPreRender() { }
		public virtual void OnRender() { }
		public virtual void OnPostRender() { }

		internal void SetParent(Element? el)
		{
			Element = el;
		}
	}
}